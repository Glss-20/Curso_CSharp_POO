using ExHeranca18.Entities;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ExHeranca18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.RegisterEmployees();
            employee.ShowDatas();
            
        }
    }
}
