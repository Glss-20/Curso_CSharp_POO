using System;
using System.IO;


namespace ExArquivo23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Documents\ESTUDOS_LACERDA\Curso_CSharp_POO - 11.10.24\ExArquivo23\Teste_ExArquivo1.txt";
            // Definimos aqui o caminho do arquivo de origem.
            string targetPath = @"D:\Documents\ESTUDOS_LACERDA\Curso_CSharp_POO - 11.10.24\ExArquivo23\Teste_ExArquivo2.txt";
            // Definimos aqui o caminho do arquivo de destino.

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                // Cria uma instância da classe "FileInfo" associada ao arquivo no caminho "sourcePath".

                fileInfo.CopyTo(targetPath);
                // Cria uma cópia do arquivo de origem no caminho de "targetPath".

                string[] lines = File.ReadAllLines(sourcePath);// Array dinâmico pelo "System.IO"
                // A função ReadAllLines vai ler todas as linha do arquivo de "sourcePath"
                // e armazena cada linha como um elemento do vetor de string "lines".
                // Função ReadAllLines: O método verifica quantas linhas o arquivo possui, cria um array com exatamente esse
                // número de elementos e preenche cada posição com o conteúdo de cada linha do arquivo.

                foreach (string line in lines) // Esse foreach vai ler linha por linha do arquivo e imprimir no terminal.
                {
                    Console.WriteLine(line);// Itera por cada linha do array e exibe no console.
                }
            }

            catch (IOException ex) // Captura e trata exceções de entrada e saída.
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
