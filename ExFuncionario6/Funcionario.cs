using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFuncionario6
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
    
        public void CadastrarFuncionario()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Salário: ");
            SalarioBruto = double.Parse(Console.ReadLine());    
            Console.Write("Imposto: ");
            Imposto = double.Parse(Console.ReadLine());
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Funcionário: {Nome} - {SalarioLiquido()}");
        }
    
        public void AumentarSalario(double porcentagem)
        {
            double SalarioAtualizado = SalarioBruto + ((SalarioBruto * porcentagem) / 100);
            SalarioBruto = SalarioAtualizado;
            Console.WriteLine($"Dados atualizados:");
            ExibirDados(); // Ele aumenta no atributo SalarioBruto e nesse método tira o imposto denovo, com o salario aumentado.
        }

    }
}
