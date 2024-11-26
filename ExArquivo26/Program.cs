using System;
using System.IO;
using System.Collections.Generic;

namespace ExArquivo26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Documents\ESTUDOS_LACERDA\Curso_CSharp_POO - 11.10.24\ExArquivo26\FolderTest";

            try
            {
                //Listar todas as subpastas da pasta de path.
                var folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //O resultado é uma coleção contendo os strings correspondentes a pasta.
                Console.WriteLine("FOLDERS: ");
                foreach (string item in folder)
                {
                    Console.WriteLine(item);
                }

                //Listar todas os arquivos da pasta de path.
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                //O resultado é uma coleção contendo os strings correspondentes aos arquivos.
                Console.WriteLine("FILES: ");
                foreach (string item in files   )
                {
                    Console.WriteLine(item);
                }

                //Criar uma pasta no caminho de path, passando o nome do arquivo novo.
                Directory.CreateDirectory(path + @"\NewFolder");

                //Diz a pasta/directory do caminho de path.
                Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
