using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExEnumAndComposition16.Entities.Enum;

namespace ExEnumAndComposition16.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }   

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public void RegisterClient()
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birt Date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date); //Atributo Client

            DateTime dateNow = DateTime.Now; //Atributo Moment

            Console.Write("Status of order(PendingPayment - Processing - Shpped - Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()); //Atributo Status

            Moment = dateNow;
            Status = status;
            Client = client;
          
        }

        public void RegisterOrder()
        {
            Console.Write("How many items to this order: ");
            int quantItems = int.Parse(Console.ReadLine());

            int cont = 0;
            while (cont < quantItems)
            {
                Console.WriteLine($"Enter item {cont + 1} data: ");

                Console.Write("Product Name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Product Price: ");
                double priceProduct = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantProduct = int.Parse(Console.ReadLine());

                OrderItem or = new OrderItem(nameProduct, quantProduct, priceProduct);
                AddItem(or);

                cont++;
            }
        } 

        public void DisplayData()//Exibir dados
        {
            Console.WriteLine("Order Sumary");
            Console.WriteLine($"Order moment: {Moment}");
            Console.WriteLine($"Order status: {Status}");
            Console.WriteLine($"Client: {Client.Name} - {Client.Email} - {Client.BirthDate}");

            Console.WriteLine($"Order Items: ");
            foreach (OrderItem item in Items)
            {
                Console.WriteLine($"Name: {item.Name} " +
                    $"- Product total: {item.SubTotal()} " +
                    $"- Quantity: {item.Quantity}");
            }

            Console.WriteLine($"Total price: {Total()}");
            Console.ReadLine();
        }
    }
}
