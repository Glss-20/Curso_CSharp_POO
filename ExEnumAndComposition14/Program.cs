using ExEnumAndComposition14.Entities;
using ExEnumAndComposition14.Entities.Enums;


namespace ExEnumAndComposition14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string deptName  = Console.ReadLine();
                
            Console.WriteLine("Enter work data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); // Aqui ele converte a "string" que o usuário digitou para o
                                                                             // tipo de "WorkerLevel".
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Departament dept = new Departament();

            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                
                Console.WriteLine("Date (DD/MM/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration(hours): ");
                int hours = int.Parse(Console.ReadLine());
                
                HourContract contract = new HourContract(date, valuePerHour, hours); // Cria uma instância do contrato.
                worker.AddContract(contract); // Adiciona essa instância.

            }

            Console.WriteLine();
            Console.Write("Enther month and year to calculate income (MM/YYYY): ");
            string monthAnYear  = Console.ReadLine();
            int month = int.Parse(monthAnYear.Substring(0,2));//Pega uma substring a par    tir do índice 0 e que tenha 2 caracteres de comprimento.
            int year = int.Parse(monthAnYear.Substring(3));// Aqui não é necessário indicar o comprimento da substring porque ela irá pegar o restante
                                                           //da string a partir do índice 3 até o fim.

            Console.WriteLine($"Name: {worker.Nome}");
            Console.WriteLine($"Department:  {worker.Departament.Name}");
            Console.WriteLine($"Income for {monthAnYear}: {worker.Income(year, month)}");
        }
    }
}
