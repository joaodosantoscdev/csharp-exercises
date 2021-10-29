using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises_7.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double value, int quantity)
        {
            Name = name;
            Value = value;
            Quantity = quantity;
        }

        public double Total()
        {
            return Value * Quantity;
        }
    }
}
