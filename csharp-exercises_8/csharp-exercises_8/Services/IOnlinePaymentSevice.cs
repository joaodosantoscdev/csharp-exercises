using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises_8.Services
{
    public interface IOnlinePaymentSevice
    {
        double PaymentFee(double amount);

        double Interest(double amount, int months);
    }
}
