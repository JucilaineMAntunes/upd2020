using System;
using System.Collections.Generic;
using System.Text;

namespace couser5.entities
{
    class Contract
    {
        public int nr { get; set; }
        public DateTime date { get; set; }

        public double toltalvalue { get; set; }

        public List<Installment> Installments { get; set; }

        public Contract(int nr, DateTime date, double toltalvalue)
        {
            this.nr = nr;
            this.date = date;
            this.toltalvalue = toltalvalue;
            Installments = new List<Installment>();
        }

   
        public void AddInstallment(Installment installment)
        {

            Installments.Add(installment);

        }
    }
}
