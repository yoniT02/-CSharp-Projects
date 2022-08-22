using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Prod
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public int inventoryNumber { get; set; }
        public string objName { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public bool isAvailable { get; set; }
        public bool chk_list { get; set; }

        private static List<Prod> products = new List<Prod>();
        public static List<Prod> GetAllProducts()
        {
            return products;
        }
        
        public static Prod findOne(string name)
        { 
          return products.Find(p => p.objName == name);
         }

        public void save()
        {
            products.Add(this);
            foreach (Prod product in products)
            {
                Console.WriteLine(product.number + ". " + product.objName);
            }
        }
    }
}


