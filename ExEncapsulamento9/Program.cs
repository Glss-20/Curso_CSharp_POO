namespace ExEncapsulamento9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria();

            c1.Cadastrar();
            Console.WriteLine("");
            c1.Deposito();
            Console.WriteLine("");
            c1.Sacar();

        }
    }
}
