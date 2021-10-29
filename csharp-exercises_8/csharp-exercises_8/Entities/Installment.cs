using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises_8.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
