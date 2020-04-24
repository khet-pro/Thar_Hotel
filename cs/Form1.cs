using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            Form3 obj = new Form3();
            obj.Show();
            
           
          
        }

        public Form1(IContainer components, PictureBox pictureBox1, PictureBox pictureBox2, TextBox textBox1, Panel panel1, PictureBox pictureBox3, TextBox textBox2, Panel panel2, Button button1, Button button2, Button button3)
        {
            this.components = components;
            this.pictureBox1 = pictureBox1;
            this.pictureBox2 = pictureBox2;
            this.textBox1 = textBox1;
            this.panel1 = panel1;
            this.pictureBox3 = pictureBox3;
            this.textBox2 = textBox2;
            this.panel2 = panel2;
            this.button1 = button1;
            this.button2 = button2;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 obj = new Form2();
            obj.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
