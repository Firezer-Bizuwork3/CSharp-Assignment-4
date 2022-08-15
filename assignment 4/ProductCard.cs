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
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }
        private string PName;

        public string pName
        {
            get { return pName; }
            set { pName = value;lbl_price.Text = value; }
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
    }
}
