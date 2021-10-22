using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises_4.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManunfactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manunfactureDate) 
                    : base(name, price)
        {
            ManunfactureDate = manunfactureDate;
        }


        public override string PriceTag()
        {
            return $"{Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, (Manunfacture date : {ManunfactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
