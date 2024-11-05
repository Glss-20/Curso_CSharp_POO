using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExEnumAndComposition14.Entities.Enums;

namespace ExEnumAndComposition14.Entities
{
    internal class Worker
    {
        public string Nome {  get; set; }
        public WorkerLevel Level { get; set; } // Associação com o Enum "WorkerLevel". Composição
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } // Associação com a classe "Departament". Composição
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>(); // Associação com a classe "HourContract". Composição

        public Worker()
        {

        }

        public Worker(string nome, WorkerLevel level, double baseSalary, Departament departament)
        {
            Nome = nome;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {

                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();   
                }

            }
            return sum;

        }
    }
}
