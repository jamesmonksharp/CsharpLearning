using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvokeTimerToControls
{
    class SetTimerTicker
    {    
        public static void SetTimeCountDownDataGridView(int timers, DataGridView dgv1, int rowIndex, int cellIndex, string message)
        {
            if (!dgv1.IsDisposed)
            {
                if (dgv1.InvokeRequired)
                {
                    dgv1.Invoke(new Action<int, DataGridView, int, int, string>(SetTimeCountDownDataGridView), timers, dgv1, rowIndex, cellIndex, message);
                    return;
                }

                //Hiển thị symbol ngôi sao
                string copyrightUnicode = "2606";
                int value = int.Parse(copyrightUnicode, System.Globalization.NumberStyles.HexNumber);
                string symbol = char.ConvertFromUtf32(value).ToString();
                
                //Lấy phút giây từ số giây
                int minuteD = (int)(Math.Floor((double)(timers / 60)));
                int secondD = timers % 60;

                //Chuẩn bị truyền vào hàm 2 biên phút giây ở trên
                CountDownTimer timer1d = new CountDownTimer();
                timer1d.SetTime(minuteD, secondD);
                timer1d.Start();
                //Thời gian > 60 giây thì hiển thị phút
                if (timers > 60)
                {
                    timer1d.TimeChanged += () => dgv1.Rows[rowIndex].Cells[cellIndex].Value = symbol + " " + message + " " + timer1d.TimeLeftStr + " phút (giây)";
                }
                else
                {
                    timer1d.TimeChanged += () => dgv1.Rows[rowIndex].Cells[cellIndex].Value = symbol + " " + message + " " + timer1d.TimeLeftStr + " giây";
                }               
                timer1d.CountDownFinished += () => dgv1.Rows[rowIndex].Cells[cellIndex].Value = symbol + "Kết thúc thời gian.";
                timer1d.StepMs = 1000;
            }
        }
    }
}
