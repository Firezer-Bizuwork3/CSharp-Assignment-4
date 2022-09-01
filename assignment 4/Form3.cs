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
            panel2.Location = new Point(0,lbl_red.Location.Y);
        }

        private void lbl_blue_Click(object sender, EventArgs e)
        {
            panel2.BackColor= Color.Blue;
            panel2.Location = new Point(0, lbl_blue.Location.Y);
        }

        private void lbl_green_Click(object sender, EventArgs e)
        {
            panel2.BackColor=Color.Green;
            panel2.Location = new Point(0, lbl_green.Location.Y);
        }

        private void lbl_black_Click(object sender, EventArgs e)
        {
            panel2.BackColor=Color.Black;
            panel2.Location = new Point(0, lbl_black.Location.Y);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productCard1_Load(object sender, EventArgs e)
        {

        }

        private void productCard2_Load(object sender, EventArgs e)
        {

        }

        private void productCard1_Load_1(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
