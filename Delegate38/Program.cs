using System;
using System.Linq;
using System.Collections.Generic;

namespace Delegate38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DELEGATE FUNC - Retorna um valor.
            List<Product> list = new List<Product>();

            // Adicionando produtos à lista.
            list.Add(new Product("TV", 300));       
            list.Add(new Product("Mouse", 50));
            list.Add(new Product("Tablet", 350));
            list.Add(new Product("HD Case", 80));

            // A lista "result" armazena o resultado da projeção feita pelo método "Select".
            // "Select" é um método de LINQ que utiliza um delegate Func para aplicar uma transformação em cada elemento da coleção.
            // O método auxiliar "NameUpper" é passado como argumento para transformar os nomes dos produtos em letras maiúsculas.
            List<string> result = list.Select(NameUpper).ToList();
            // No lugar do método "NameUpper" poderiamos usar uma funçã Lambda - Acredito que é o ideal.

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        // Método auxiliar que implementa o delegate Func.
        // Recebe um objeto do tipo Product como parâmetro e retorna uma string (o nome do produto em caixa alta).
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
