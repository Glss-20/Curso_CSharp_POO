using ExEnum13.Entities.Enum;
using ExEnum13.Entities;

namespace ExEnum13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment// Puxa da classe dos enum o "OrderStatus.PendingPayment"
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //Converte de Enum para string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //Converte de string para Enum


            Console.WriteLine(txt);
            Console.WriteLine(os);
        }


    }
    }
}
