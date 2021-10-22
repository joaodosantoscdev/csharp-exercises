using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises_5.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpeditures { get; set; }

        public Individual(string name, double income, double healthExpeditures)
               : base(name, income)
        {
            HealthExpeditures = healthExpeditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpeditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpeditures * 0.5;
            }
        }
    }
}
