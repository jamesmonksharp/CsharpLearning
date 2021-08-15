using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCsharpWithJackie
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeViewManage twm = new TreeViewManage();
            twm.AddNode(textBox1.Text, treeView1);                                          
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Nếu tạo 2 root node
            //Thì lúc tạo node con phải chọn root node cần tạo
            //Viết hàm


            //Này chỉ tạo 1 rootnode rồi thêm các child node liên tục cho node này
            TreeViewManage twm = new TreeViewManage();

            //Lấy danh sách các node trong treeview1
            TreeNodeCollection nodes = treeView1.Nodes;
            if (nodes.Count > 0)
            {
                //Kiểm tra xem số lượng node con
                if (nodes[0].Nodes.Count <= 0)
                {
                    //Nếu <=0 [tức là chưa có node con]
                    //Thêm node con với tên "Option1"
                    twm.AddChildNode(textBox2.Text, nodes[0]);
                }
                else
                {
                    //Substring ở đây tuỳ theo text trong textbox2 với con số phía sau
                    string originalNodeName = textBox2.Text.Substring(0, 6);

                    //Trường hợp đã có node con
                    //Lấy con số cuối của node cuối cùng trong treeview
                    string lastNode = nodes[0].LastNode.Text.Substring(6);
                    //string d = Option1
                    //Substring(6) thì đếm từ option là 6 ký tự
                    //và vị trí thứ 6

                    //Tăng lên 1 con số phía sau tên node con
                    int incrementNode = Convert.ToInt32(lastNode) + 1;                    
                    
                    //Tạo biến string chứa tên node con và biến tăng 1
                    string newNodeIncrement = originalNodeName + incrementNode.ToString();

                    //Thêm node con khác với tên và id phía sau tên tăng lên
                    twm.AddChildNode(newNodeIncrement, nodes[0]);
                    
                    //Như vậy khi nhấn button, tự động tạo node con với con số cuối tăng dần

                }
            }
        }


        //Rootnode check thì childnode check
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeViewManage twm = new TreeViewManage();
            if (e.Node.Checked)
                twm.CheckAllChildNodes(e.Node, true);
            else
                twm.CheckAllChildNodes(e.Node, false);
        }

        //Treeview selectedNode chỉnh sửa bằng F2
        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F2))
            {
                treeView1.LabelEdit = true;
                treeView1.SelectedNode.BeginEdit();
            }
        }

        //Sau khi chỉnh sửa xong
        private void treeView1_Enter(object sender, EventArgs e)
        {
            treeView1.LabelEdit = false;
        }

        //Sau khi chỉnh sửa xong
        private void treeView1_Click(object sender, EventArgs e)
        {
            treeView1.LabelEdit = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeViewManage twm = new TreeViewManage();   
            TreeNodeCollection nodes = treeView1.Nodes;
            if (nodes.Count > 0)
            {
                //Lấy giá trị node cần chọn
                TreeNode selectedNode = treeView1.SelectedNode;

                //Nếu null 
                if (selectedNode == null)
                {
                    //Báo lỗi
                    MessageBox.Show("Bạn chưa chọn root node nào.");
                }
                else
                {
                    //Nếu ko null, tức là đã chọn 1 node

                    //Kiểm tra số lượng node trong selectedNode đã chọn

                    //Nếu <= 0, tức là chưa có node con
                    if (selectedNode.Nodes.Count <= 0)
                    {
                        //Add node con có tên là textbox3.text vào node đã chọn
                        twm.AddChildNodeSelected(textBox3.Text, selectedNode);
                    }
 
                    //Trường hợp đã có node con
                    else
                    {
                        //Lấy tên node không có số phía sau
                        string originalNodeName = textBox3.Text.Substring(0, 6);
                        //Option1
                        //Lấy số phía sau của node con cuối trong node đã chọn
                        string lastNode = selectedNode.LastNode.Text.Substring(6);
                        //Option1 = vị trí thứ 6 trở đi ko lấy vị trí 6 = 1
                        //Tăng lên 1
                        int incrementNode = Convert.ToInt32(lastNode) + 1;
                        //Set giá trị cho biến mới
                        string newNodeIncrement = originalNodeName + incrementNode.ToString();
                        //Thêm node con mới với giá trị biến mới ở trên vào node đang chọn
                        twm.AddChildNodeSelected(newNodeIncrement, selectedNode);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa tạo root node.");
            }
        }
    }
}
