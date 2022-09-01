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
    public partial class DetailPage : Form
    {
        public DetailPage(product products)
        {
            InitializeComponent();
            lbl_count.Text = products.count.ToString();
            lbl_date.Text = products.date.ToString();
            lbl_InventoryNumber.Text = products.inventoryNumber.ToString();
            lbl_number.Text = products.number.ToString();
            lbl_ObjectName.Text = products.objectname;
            lbl_price.Text = products.price.ToString();
            Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DetailPage_Load(object sender, EventArgs e)
        {

        }
    }
}
