using System; 
using System.Globalization; 
using System.IO; 
using ExArquivo27.Entities; 


namespace ExArquivo27
{

    class Program
    {
        
        static void Main(string[] args)
        {
            // Solicita ao usuário o caminho completo do arquivo e lê a entrada
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                // Lê todas as linhas do arquivo especificado em "sourceFilePath".
                string[] lines = File.ReadAllLines(sourceFilePath);

                // Obtém o diretório do arquivo de origem
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                // Define o caminho da pasta de destino (um subdiretório "out")
                string targetFolderPath = sourceFolderPath + @"\out";
                // Define o caminho do arquivo de destino (dentro da pasta "out")
                string targetFilePath = targetFolderPath + @"\summary.csv";

                // Cria o diretório "out" caso ainda não exista
                Directory.CreateDirectory(targetFolderPath);

                // Abre (ou cria) o arquivo summary.csv no modo de anexo (append), garantindo que, ao finalizar o bloco, ele seja fechado
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    // Loop para processar cada linha do arquivo de origem
                    foreach (string line in lines)
                    {
                        // Divide a linha em partes, assumindo que os campos são separados por vírgula
                        string[] fields = line.Split(',');
                        // Extrai o nome do produto (primeiro campo)
                        string name = fields[0];
                        // Extrai o preço do produto e converte para double.
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        // Extrai a quantidade do produto e converte para int
                        int quantity = int.Parse(fields[2]);

                        // Cria um objeto Product usando os dados extraídos
                        Product prod = new Product(name, price, quantity);

                        // Escreve no arquivo de destino o nome do produto e o valor total (quantidade * preço) calculado pelo método Total
                        sw.WriteLine(prod.Name + "," + prod.Total());
                    }
                }
            }
            // Bloco para capturar exceções de entrada e saída
            catch (IOException e)
            {
                Console.WriteLine("An error occurred"); // Exibe mensagem genérica de erro
                Console.WriteLine(e.Message); // Exibe a mensagem específica do erro
            }
        }
    }
}
