using System;
using System.IO;

namespace ExArquivo24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Documents\ESTUDOS_LACERDA\Curso_CSharp_POO - 11.10.24\ExArquivo24\Teste_ExArquivo1.txt";
            
            
            StreamReader sr = null; // Declaração de um StreamReader, utilizado para ler arquivos de texto de forma otimizada.

            try
            {
                // O método File.OpenText(path) cria automaticamente um FileStream internamente e usa-o para instanciar o StreamReader.

                sr = File.OpenText(path);// Implicitamente instancia o FileStream e instancia o StreamReader em cima dele,
                                         // basta informamos o caminho do arquivo.

                while (!sr.EndOfStream)// Enquanto não chegar ao final do Stream/Arquivo.
                {
                    string line = sr.ReadLine(); // Lê uma linha do arquivo e exibe no console.
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An erro accurred");
                Console.WriteLine(ex.Message);
            }
            finally //Independente de ter ou não exceção temos que fechar os arquivos manualmente, porque eles não são gerenciados pelo CRL do .NET.
            {
                if (sr != null) sr.Close();// Libera recursos fechando o StreamReader, garantindo que o arquivo seja liberado do sistema.
            }

        }
    }
}
