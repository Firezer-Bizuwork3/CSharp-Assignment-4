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
        private string _title;

        public string  Title
        {
            get { return _title; }
            set { _title= value;lbl_title.Text = Title; }
        }
        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price = value; lbl_price.Text =Price; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value;lbl_description.Text = Description; }
        }

      



        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
    }
}
