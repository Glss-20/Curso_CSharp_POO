using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExGenerics30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de um conjunto (HashSet) para armazenar registros únicos de log. 
            // O tipo genérico <LogRecord> indica que o conjunto conterá objetos do tipo LogRecord.
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            // Solicita ao usuário que insira o caminho completo de um arquivo de log.
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine(); // Armazena o caminho fornecido pelo usuário na variável 'path'.

            try
            {
                // Utiliza o 'using' para garantir que o StreamReader será fechado automaticamente após o uso.
                using (StreamReader sr = File.OpenText(path))
                {
                    // Enquanto o arquivo não chegar ao final, o loop continua lendo as linhas.
                    while (!sr.EndOfStream)
                    {
                        // Lê uma linha do arquivo, separa o texto com base no espaço (' ') e armazena as partes em um array de strings.
                        string[] line = sr.ReadLine().Split(' ');

                        // O primeiro elemento da linha é o nome do usuário.
                        string name = line[0];

                        // O segundo elemento da linha é convertido para um objeto DateTime, representando o momento do log.
                        DateTime instant = DateTime.Parse(line[1]);

                        // Adiciona um novo objeto LogRecord ao HashSet. 
                        // O HashSet garante que apenas registros únicos sejam armazenados, 
                        // com base na implementação de 'Equals' e 'GetHashCode' na classe LogRecord.
                        set.Add(new LogRecord { UserName = name, Instant = instant });
                    }

                    // Exibe o número total de usuários únicos (com base no HashSet) encontrados no arquivo.
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e) // Captura e trata possíveis erros de entrada/saída, como falha ao abrir ou ler o arquivo.
            {
                // Exibe a mensagem de erro no console, permitindo ao usuário saber o que aconteceu.
                Console.WriteLine(e.Message);
            }
        }
    }
}

