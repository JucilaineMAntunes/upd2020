using System;
using course1.Entities;
using course1.Entities.Enuns;

namespace course1.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public int MyProperty { get; set; }

        public OrderStatus Status { get; set; }

        public override string ToString()  //subsescrevendo um metodo
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
