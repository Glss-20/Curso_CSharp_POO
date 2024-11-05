namespace ExFuncionario6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            f1.CadastrarFuncionario();

            f1.ExibirDados();

            Console.WriteLine(f1.SalarioBruto);

            Console.Write("Porcentagem para aumentar o salário: ");
            double porcen = double.Parse(Console.ReadLine());
            f1.AumentarSalario(porcen);
            

            Console.ReadLine(); 
        }
    }
}
