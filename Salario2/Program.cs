namespace ExSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados primeiro funcionário: ");
            Console.Write("Nome: ");
            string n1 = Console.ReadLine();
            Console.Write("Salario: ");
            double s1 = double.Parse(Console.ReadLine());
            
            Funcionario f1 = new Funcionario(n1, s1);

            Console.WriteLine("Dados segundo funcionário: ");
            Console.Write("Nome: ");
            string n2 = Console.ReadLine();
            Console.Write("Salario: ");
            double s2 = double.Parse(Console.ReadLine());

            Funcionario f2 = new Funcionario(n2, s2);


            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine($"A média do salário de {f1.Nome} e de {f2.Nome} é igua a {media}!");
        }
    }
}
