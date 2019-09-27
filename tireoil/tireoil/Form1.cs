using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tireoil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidepanel.Height = btnStock.Height;
            userControl11.BringToFront();
            //lbltime.Text = DateTime.Now.ToString();
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnStock.Height;
            sidepanel.Top = btnStock.Top;
            userControl11.BringToFront();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void UserControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void UserControl11_Load_2(object sender, EventArgs e)
        {

        }
    }
}
