using System;

using couser5.entities;
using couser5.Services;

namespace couser5.Services
{

    class ContractService
    {



        private IOneLinePaymentService _onlinePaymentService;



        public ContractService(IOneLinePaymentService onlinePaymentService)
        {

            _onlinePaymentService = onlinePaymentService;

        }



        public void ProcessContract(Contract contract, int months)
        {

            double basicQuota = contract.toltalvalue / months;

            for (int i = 1; i <= months; i++)
            {

                DateTime date = contract.date.AddMonths(i);

                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);

                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(fullQuota, date ));

            }

        }

    }

}