using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Good
    {
        public Good(string name, string description, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
