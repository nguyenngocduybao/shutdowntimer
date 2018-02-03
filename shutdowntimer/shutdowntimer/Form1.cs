using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shutdowntimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ShutDown(string command)
        {
            System.Diagnostics.Process.Start("shutdown", command);
        }
        //ShutDown - Restart - Sleep lập tức
        private void pic_Shutdown_Click(object sender, EventArgs e)
        {

        }

        private void pic_Restart_Click(object sender, EventArgs e)
        {

        }

        private void pic_Sleep_Click(object sender, EventArgs e)
        {

        }
        //Hẹn giờ
        decimal Time = 0;
        
        void downTime()
        {
            Time = numeric_Giay.Value + numeric_Phut.Value * 60 + numeric_Gio.Value * 60 * 60;

        }

        private void numeric_Phut_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;

            if (box.Value>=60)
            {
                numeric_Gio.Value++;
                box.Value = 0;
            }
        }

        private void numeric_Giay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;

            if (box.Value >= 60)
            {
                numeric_Phut.Value++;
                box.Value = 0;
            }
        }

        private void btn_ShutDown_Click(object sender, EventArgs e)
        {
            downTime();
            ShutDown("-s -t" + Time);
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            downTime();
            ShutDown("-r -t" + Time);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            //shutdown -a = Hủy lệnh
            ShutDown("-a");
        }


    }
}
