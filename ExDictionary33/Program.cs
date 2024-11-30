using System;

namespace ExDictionary33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o caminho completo do arquivo que contém os dados de votação.
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine(); // Lê o caminho do arquivo inserido pelo usuário.

            try
            {
                // Abre o arquivo de texto no caminho especificado, utilizando o bloco 'using' para garantir que o arquivo será fechado corretamente após o uso.
                using (StreamReader sr = File.OpenText(path))
                {
                    // Cria um dicionário para armazenar o número de votos por candidato.
                    // O 'string' representa o nome do candidato e o 'int' o número total de votos.
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    // Lê o arquivo linha por linha até alcançar o final.
                    while (!sr.EndOfStream)
                    {
                        // Divide a linha lida em duas partes: nome do candidato e número de votos.
                        // As partes são separadas por uma vírgula no arquivo.
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0]; // Candidato é a chave.
                        int votes = int.Parse(votingRecord[1]); // Votos é o valor da chave candidato.

                        // Verifica se o dicionário já contém uma entrada para o candidato.
                        if (dictionary.ContainsKey(candidate))
                        {
                            // Se o candidato já existe no dicionário, adiciona os votos à contagem existente.
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            // Se o candidato ainda não existe no dicionário, cria uma nova entrada.
                            dictionary[candidate] = votes;
                        }

                        // Exibe no console os dados lidos da linha para verificação.
                        Console.WriteLine(candidate); // Exibe o nome do candidato.
                        Console.WriteLine(votes);     // Exibe o número de votos.
                        Console.WriteLine("=================================="); // Exibe um separador.
                    }

                    // Após processar todas as linhas do arquivo, exibe o resultado final.
                    // O foreach percorre todas as entradas do dicionário.
                    foreach (var item in dictionary)
                    {
                        // Exibe o nome do candidato e sua contagem total de votos.
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                // Captura exceções relacionadas à leitura do arquivo.
                Console.WriteLine("An error occurred"); // Exibe uma mensagem genérica.
                Console.WriteLine(e.Message); // Exibe detalhes da exceção.
            }
        }
    }
}
