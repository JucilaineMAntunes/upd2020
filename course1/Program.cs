using System;
using course1.Entities;
using course1.Entities.Enuns;

namespace course1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendindPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendindPayment.ToString();
            OrderStatus os = Enum.Parse < OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}

