using System.Globalization;

namespace Linq42
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter full file path:");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] camps = sr.ReadLine().Split(',');
                    string name = camps[0];
                    string email = camps[1];
                    double salary = double.Parse(camps[2]);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Salary parameter: ");
            double salaryParameter = double.Parse(Console.ReadLine());

            var emails = list.Where(e => e.Salary >= salaryParameter).OrderByDescending(e => e.Email).Select(e => e.Email);
            foreach (var emp in emails)
            {
                Console.WriteLine(emp);
            }


        }
    }
}
