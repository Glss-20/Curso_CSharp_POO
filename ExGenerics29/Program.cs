using System;
using System.Runtime.InteropServices;

namespace ExGenerics29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("How many products add: ");
            int quant = int.Parse(Console.ReadLine());

            int cont = 0; 
            while (cont < quant)
            {
                Console.Write($"Thing {cont + 1}: "); 

                string[] vect = Console.ReadLine().Split('-');
                // Espera um formato com um nome e um preço separados por um hífen (e.g., "Produto-10.50").
                // O método Split('-') divide a entrada em um array de strings, separando o nome e o preço em dois elementos do array "vect".

                float price = float.Parse(vect[1]);
                // Converte a segunda parte da entrada (o preço) para um número do tipo float, usando o elemento vect[1].
                // Aqui é esperado que vect[1] seja uma string representando um número que pode ser convertido para float.

                list.Add(new Product(vect[0], price));
                // Cria uma nova instância da classe Product, passando o nome (vect[0]) e o preço (price) como argumentos para o construtor.
                // Adiciona o novo objeto Product à lista (list), que armazena todos os produtos.

                cont++;
            }

            CalculationsService calculationsService = new CalculationsService();

            Product max = calculationsService.Max(list);
            Console.WriteLine($"Max: {max}");

        }
    }
}
    