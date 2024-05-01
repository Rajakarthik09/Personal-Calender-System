using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Calender_System
{
    public partial class Form3 : Form
    {
        private string username;
        public Form3(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new Form1();
            f1.FormClosed += (s, args) => this.Close();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f4 = new Form4();
            f4.FormClosed += (s, args) => this.Close();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (username == "manager")
            {
                this.Hide();
                var f7 = new Form7();
                f7.FormClosed += (s, args) => this.Close();
                f7.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f9 = new Form9();
            f9.FormClosed += (s, args) => this.Close();
            f9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f11 = new Form11();
            f11.FormClosed += (s, args) => this.Close();
            f11.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f14 = new Form14();
            f14.FormClosed += (s, args) => this.Close();
            f14.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f14 = new Form14();
            f14.FormClosed += (s, args) => this.Close();
            f14.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f16 = new Form16();
            f16.FormClosed += (s, args) => this.Close();
            f16.Show();
        }
    }
}
