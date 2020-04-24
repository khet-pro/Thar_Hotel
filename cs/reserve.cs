using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs
{
    public partial class reserve : UserControl
    {
        public reserve()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Reservation is Currently being processed! ");
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
