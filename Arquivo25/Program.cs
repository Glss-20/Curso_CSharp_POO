using System;
using System.IO; // Inclui o namespace System.IO, que contém classes para manipulação de arquivos.

namespace ExArquivo25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define o caminho do arquivo que será lido.
            string path = @"D:\Documents\ESTUDOS_LACERDA\Curso_CSharp_POO - 11.10.24\ExArquivo25\Teste_ExArquivo1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                // O "using" garante que o StreamReader será automaticamente fechado após o bloco ser concluído.
                // Isso é útil para liberar o arquivo e evitar que ele fique aberto, mesmo em caso de exceções.
                {
                    // Lê o arquivo linha por linha até que todo o conteúdo tenha sido lido.
                    while (!sr.EndOfStream) // sr.EndOfStream indica se o final do arquivo foi alcançado.
                    {
                        // Lê a próxima linha do arquivo e a armazena na variável "line".
                        string line = sr.ReadLine();

                        // Exibe a linha lida no console.
                        Console.WriteLine(line);
                    }
                } // Aqui o StreamReader "sr" é automaticamente fechado.
            }
            catch (IOException e) // Captura exceções de entrada/saída que podem ocorrer durante a leitura do arquivo.
            {
                // Exibe a mensagem de erro caso ocorra uma exceção de E/S.
                Console.WriteLine(e.Message);
            }
        }
    }
}
