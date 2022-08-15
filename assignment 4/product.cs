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
        public static List<String>checkedBoxes=new List<String>();
        public void save(product p)
        {
            
        }
        public static List<product> getall()
        {
            return product.products;
        }
        
            
    }
}
