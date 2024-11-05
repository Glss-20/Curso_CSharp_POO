using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExLista11
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public static List<Funcionario> CadastrarFuncionario(int quant)
        {
            List<Funcionario> func = new List<Funcionario>();

            int cont = 0;
            while (quant > cont)
            {
                Console.WriteLine($"Funcionario {cont + 1}: ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                func.Add(new Funcionario(id, name, salario));

                cont++;
            }

            return func;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"{Id}, {Name}, {Salary}");   
        }

        public static void ExibirTodos(List<Funcionario> lista)
        {
            Console.WriteLine("Lista de funcionários: ");
            foreach (Funcionario l in lista)// "l" refere-se a cada objeto dentro de "lista", que pode ser qualque lista que foi passada pelo parâmetro.
            {
                l.ExibirDados();
            }
        }


        public static void AumentarSalarioID(List<Funcionario> lista)
        {
            Console.Write("Aumentar salário - ID do funcionario: ");
            int id1 = int.Parse(Console.ReadLine());

            Funcionario acharFunc = lista.Find(f => f.Id == id1);

            if (acharFunc != null)
            {
                Console.Write("Porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine());
                acharFunc.AumentarSalario(porcentagem);

                Console.WriteLine("Dados atualizados: ");
                acharFunc.ExibirDados();

            }
            else
            {
                Console.WriteLine("Funcionário não encontrado!");
            }

        }

        public void AumentarSalario(double porcent)
        {
            Salary += (Salary * porcent) / 100;

        }
    }
}
