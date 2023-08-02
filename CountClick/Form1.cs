using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountClick
{
    public partial class Form1 : Form
    {
        int times = 0; //變數如果宣告在程式裡面，程式跑完變數會消失


        public Form1()
        {
            InitializeComponent();
        }

        private void labelShow_Click(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            times++;
            labelShow.Text = "你已點了滑鼠  " +  times.ToString() + "下"; //顯示的是文字，要放字串
        }

        private void btResert_Click(object sender, EventArgs e)
        {
            times=0;
            labelShow.Text = "你已點了滑鼠  0下";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
