using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace couser5.entities
{
    class Installment
    {

        public double  Amount { get; set; }
        public DateTime DueDate { get; set; }

        public Installment(double amount, DateTime duedate)
        {
            Amount = amount;
            DueDate = duedate;
        }

        public override string ToString()
        {

            return DueDate.ToString("dd/MM/yyyy")

                + " - "

                + Amount.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
