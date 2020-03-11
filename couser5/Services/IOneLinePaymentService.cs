using System;
using System.Collections.Generic;
using System.Text;

namespace couser5.Services
{
    interface IOneLinePaymentService
    {
        double PaymentFee(double amount);

        double Interest(double amount, int months);


    }
}
