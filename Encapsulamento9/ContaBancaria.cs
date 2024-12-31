using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEncapsulamento9
{
    public class ContaBancaria
    {
        public int Nconta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        private double _taxa = 5;

   
        public void Cadastrar()
        {
            Console.Write("Numero da conta: ");
            Nconta = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            Titular = Console.ReadLine();

            Console.Write("Deseja realizar um déposito inicial(S/N)?:");
            string op = Console.ReadLine();
            if (op == "S" || op == "s")
            {
                Console.WriteLine("Depósito inicial ");
                Deposito();
            }
            else
            {
                Console.WriteLine("Dados da conta: ");
                ExibirDados();
            }

        }

        public void ExibirDados()
        {
            Console.WriteLine($"Número conta: {Nconta} / Titula: {Titular} / Saldo {Saldo}");
        }

        public void Deposito()
        {
            Console.Write("Valor do depósito: ");
            double valor = double.Parse(Console.ReadLine());
            Saldo += valor;
            Console.WriteLine("Dados da conta atualizados: ");
            ExibirDados();
        }

        public void Sacar()
        {
            Console.Write("Valor do saque: ");
            double valor = double.Parse(Console.ReadLine());
            Saldo -= (valor + _taxa);
            Console.WriteLine("Dados da conta atualizados: ");
            ExibirDados();
        }

    }
}
