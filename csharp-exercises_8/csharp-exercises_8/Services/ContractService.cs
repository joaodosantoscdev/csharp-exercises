using csharp_exercises_8.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises_8.Services
{
    class ContractService
    {
        private IOnlinePaymentSevice _onlinePaymentSevice;

        public ContractService(IOnlinePaymentSevice onlinePaymentService)
        {
            _onlinePaymentSevice = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 0; i <= months; i++ )
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentSevice.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentSevice.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
