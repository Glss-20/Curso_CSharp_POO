namespace ExLista11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> func = new List<Funcionario>();

            Console.WriteLine("Quantos funcionarios registrar? ");
            int quant = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = Funcionario.CadastrarFuncionario(quant);

            // "List<Funcionario>" declara que a variável, que será do tipo "List<Funcionario>", ou seja, uma lista que armazena
            // objetos da classe "Funcionario". 

            // "CadastrarFuncionario" é o método estático que foi declarado dentro da classe "Funcionario". Ele recebe um parâmetro (quantidade),
            // que representa o número de funcionários que devem ser registrado E esse método retorna uma "List<Funcionario>" contendo os funcionários
            // que foram registrados.

            // Se o método "CadastrarFuncionario" não retornasse um valor do tipo "List<Funcionario>" a variável daria erro.
            // Como a váriavel está declarado do tipo "List<Funcionario>", tudo que ela receber deve ser desse tipo também, que 
            // nesse caso seria o retorno do método "CadastrarFuncionario".


            Funcionario.ExibirTodos(funcionarios);
            Funcionario.AumentarSalarioID(funcionarios);
            Funcionario.ExibirTodos(funcionarios);

            
         

        }
    }
}
