namespace ExConjuntos31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria três conjuntos (HashSet) para armazenar os códigos dos estudantes de cada curso.
            // HashSet é utilizado porque não permite duplicatas, garantindo que cada código de estudante seja único.
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            // Solicita a quantidade de estudantes para o curso A.
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine()); // Lê o número de estudantes como entrada.

            // Executa um loop para ler os códigos dos estudantes do curso A.
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine()); // Lê o código do estudante.
                courseA.Add(cod); // Adiciona o código ao conjunto do curso A.
            }

            // Solicita a quantidade de estudantes para o curso B.
            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine()); // Atualiza a variável 'n' com a nova entrada.

            // Executa um loop para ler os códigos dos estudantes do curso B.
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine()); // Lê o código do estudante.
                courseB.Add(cod); // Adiciona o código ao conjunto do curso B.
            }

            // Solicita a quantidade de estudantes para o curso C.
            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine()); // Atualiza novamente a variável 'n' com a nova entrada.

            // Executa um loop para ler os códigos dos estudantes do curso C.
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine()); // Lê o código do estudante.
                courseC.Add(cod); // Adiciona o código ao conjunto do curso C.
            }

            // Cria um novo conjunto 'all', inicializando com os elementos do conjunto do curso A.
            HashSet<int> all = new HashSet<int>(courseA);

            // Usa o método UnionWith para unir os elementos do conjunto do curso B ao conjunto 'all'.
            // Isso adiciona os elementos de courseB a 'all', sem duplicar elementos existentes.
            all.UnionWith(courseB);

            // Usa o método UnionWith novamente para unir os elementos do conjunto do curso C ao conjunto 'all'.
            all.UnionWith(courseC);

            // Exibe o número total de estudantes únicos entre todos os cursos.
            // O HashSet garante que cada estudante seja contado apenas uma vez, mesmo que pertença a vários cursos.
            Console.WriteLine("Total students: " + all.Count);

        }
    }
}
