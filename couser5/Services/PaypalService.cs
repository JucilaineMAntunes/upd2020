using System;
using System.Collections.Generic;
using System.Text;

namespace couser5.Services
{
    class PaypalService : IOneLinePaymentService
    {
        private const double FeePercentage = 0.02;

        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {

            return amount * MonthlyInterest * months;

        }

        public double PaymentFee(double amount)
        {

            return amount * FeePercentage;

        }
    }

}
