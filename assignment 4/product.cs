using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    internal class product
    {
        public string number { get; set; }
        public DateTime date { get; set; }
        public string inventoryNumber { get; set; }
        public String objectname{ get; set; }
        public string count { get; set; }
        public string price { get; set; }

        public string Items { get; set; }

        private static List<product> products = new List<product>();
       
        public void save()
        {
            //product.Add(this);
            //MessageBox.show($"{objectname} added successfully");
          
        }
        public static List<product> getallproducts()
        {
            return product.products;
        }
        public static List<product> SearchByName(string s)
        {
            return getallproducts().FindAll(product =>product.objectname == s);
        }
        public static product SearchByInventoryNumber (string InventoryNumber)
        {
            return getallproducts().Find(x => x.inventoryNumber == InventoryNumber);
        }


    }
}
