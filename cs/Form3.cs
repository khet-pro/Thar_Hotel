using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace cs
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            side.Top = button1.Top;
            welcome1.BringToFront();


        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Side_Paint(object sender, EventArgs e)
        { }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            side.Height = button2.Height;
            side.Top = button2.Top;
            reserve1.BringToFront();
           

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            side.Height = button1.Height;
            side.Top = button1.Top;
            welcome1.BringToFront();

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            side.Height = button3.Height;
            side.Top = button3.Top;
            about1.BringToFront();
            

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            side.Height = button4.Height;
            side.Top = button4.Top;
            contactus1.BringToFront();
      

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            side.Height = button5.Height;
            side.Top = button5.Top;
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }
        private void Button11_Click_1(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Process.Start("wwww.facebook.com");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Process.Start("wwww.twitter.com");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Process.Start("wwww.youtube.com");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            side.Height = button11.Height;
            side.Top = button11.Top;
            more1.BringToFront();
           
        }

        private void More1_Load(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }
    }
}
