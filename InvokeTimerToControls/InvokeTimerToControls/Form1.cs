using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvokeTimerToControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("test.txt");
            string[] columnnames = file.ReadLine().Split(',');           
            DataTable dt = new DataTable();
            foreach (string c in columnnames)
            {
                dt.Columns.Add(c);
            }
            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                DataRow dr = dt.NewRow();
                string[] values = newline.Split(',');
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;            
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 440;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAction();
        }

        private async void GetAction()
        {
            int action1 = Convert.ToInt32(textBox1.Text);
            int action2 = Convert.ToInt32(textBox2.Text);
            int action3 = Convert.ToInt32(textBox3.Text);
            await Task.Run(async () =>
            {
                int rowi = 0;
                while (rowi <= dataGridView1.Rows.Count - 1)
                {
                    List<Task> Tasks = new List<Task>();
                    for (int i = 0; i < 2; i++)
                    {
                        Tasks.Add(DoAction(rowi, action1, action2, action3, dataGridView1));
                        Thread.Sleep(300);
                        rowi++;
                    }
                    await Task.WhenAll(Tasks.ToArray());
                }
            });      
           
        }

        private async Task DoAction(int rowi, int action1, int action2, int action3, DataGridView dgv1)
        {
            await Task.Run(() =>
            {
                dgv1.Rows[rowi].Selected = true;
                SetTimerTicker.SetTimeCountDownDataGridView(action1, dgv1, rowi, 2, "Thực hiện thao tác 1 trong: ");
                Thread.Sleep(action1 * 1000);
                SetTimerTicker.SetTimeCountDownDataGridView(action2, dgv1, rowi, 2, "Thực hiện thao tác 2 trong: ");
                Thread.Sleep(action2 * 1000);
                SetTimerTicker.SetTimeCountDownDataGridView(action2, dgv1, rowi, 2, "Thực hiện thao tác 3 trong: ");
                Thread.Sleep(action3 * 1000);
                dgv1.Rows[rowi].Selected = false;
                Thread.Sleep(2000);
            });
            
        }
    }
}
