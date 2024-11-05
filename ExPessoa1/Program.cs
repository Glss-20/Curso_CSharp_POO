using System;

namespace ExPessoa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            string n1 = Console.ReadLine();
            Console.Write("Idade: ");
            int i1 = int.Parse(Console.ReadLine());

            Pessoa p1 = new Pessoa(n1, i1);

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            string n2 = Console.ReadLine();
            Console.Write("Idade: ");
            int i2 = int.Parse(Console.ReadLine());

            Pessoa p2 = new Pessoa(n2, i2);

            Console.WriteLine();  
            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"O {p1.Nome} é mais velho que o {p2.Nome}");
            }
            else
            {
                Console.WriteLine($"O {p2.Nome} é mais velho que o {p1.Nome}");
            }

        }
    }
}
