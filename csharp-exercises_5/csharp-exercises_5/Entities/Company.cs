using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises_5.Entities
{
    class Company : TaxPayer
    {
        public int NumEmployees { get; set; }

        public Company(string name, double income, int numEmployees) 
               : base (name, income)
        {
            NumEmployees = numEmployees;
        }

        public override double Tax()
        {
            if (NumEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
