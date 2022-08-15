using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lbl_red_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void lbl_blue_Click(object sender, EventArgs e)
        {
            panel2.BackColor= Color.Blue;
        }

        private void lbl_green_Click(object sender, EventArgs e)
        {
            panel2.BackColor=Color.Green;
        }

        private void lbl_black_Click(object sender, EventArgs e)
        {
            panel2.BackColor=Color.Black;    
        }
    }
}
