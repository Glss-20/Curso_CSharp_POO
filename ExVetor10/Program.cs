namespace ExVetor10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented: ");
            int quant = int.Parse(Console.ReadLine());

            Aluguel[] rooms = new Aluguel[10];
            
            int cont = 0;
            while (cont < quant)
            {
                Console.WriteLine($"Rent #{cont+1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                if (rooms[room] == null)
                {
                    rooms[room] = new Aluguel { Name = name, Email = email, Room = room };
                }
                else
                {
                    Console.WriteLine("Room ocuped");
                }
                Console.WriteLine("");
                cont++;
            }

            Console.WriteLine("\nBusy rooms");
            int cont1 = 0;
            while (cont1 < rooms.Length)
            {
                if (rooms[cont1] != null)
                {
                    Console.WriteLine($"Room {cont1}: {rooms[cont1].Name}, " +
                                             $"{rooms[cont1].Email}");
                }
                else
                {
                    Console.Write("");
                }
                cont1++;
            }

        }
    }
}
