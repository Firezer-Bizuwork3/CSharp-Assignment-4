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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox1.Text;
            if (username == "admin" && password == "admin")
            {
                Form1 screen=new Form1();
                screen.Show();
                Hide();
               // MessageBox.Show("welcome");
            }else
            {
                MessageBox.Show("inccorect");
            }
        }
    }
}
