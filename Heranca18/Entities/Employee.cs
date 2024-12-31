using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca18.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public List<Employee> list = new List<Employee>();

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public void RegisterEmployees()
        {
            Console.Write("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());

            int cont = 0;
            while (cont < n)
            {
                Console.WriteLine($"Employee {cont + 1}# data: ");
                Console.Write("Outsourced?(y/n): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutSoucerdEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                cont++;
            }
        }

        public void ShowDatas()
        {
            Console.WriteLine("PAYMENTS");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - {emp.Payment()}");
            }
        }

        public virtual double Payment()
        // O "virtual" está liberando o método para que ele possa ser sobrescrito,
        // já que na subclasse esse método pode ter um comportamento diferente.
        {
            return ValuePerHour * Hours;
        }
    }
}
