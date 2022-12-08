using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Product
    {
        public string IMG { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }



        public Product(string IMG, string Name, double Price)
        {
            this.IMG = IMG;
            this.Name = Name;
            this.Price = Price;
        }

    }
}
