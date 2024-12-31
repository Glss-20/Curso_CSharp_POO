using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAluno7
{
    public class Aluno
    {
        string Nome;
        double Nota1;
        double Nota2;
        double Nota3;

        public void CadastrarAluno()
        {
            Console.Write("Nome do aluno:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno para cada trimestre: ");
            Console.Write("Nota 1º trimestre: ");
            Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2º trimestre: ");
            Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3º trimestre: ");
            Nota3 = double.Parse(Console.ReadLine());

        }

        private double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        
        public void Situacao()
        {
            if (Nota1 + Nota2 + Nota3 >= 60)
            { 
                Console.WriteLine($"Nota final: {NotaFinal()}");
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine($"Nota final: {NotaFinal()}");
                Console.WriteLine("Aluno reprovado!");
            }
        }
    }
}
