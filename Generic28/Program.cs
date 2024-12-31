using System;

namespace ExGeneric28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();
            // As funcionalidades da classe "PrintService" servem funcionam para qualquer tipo de dado,
            // para definirmos o tipo de dado que queremos devemos passar na hora que instaciamos a classe de tipo Genérico.

            Console.Write("How many values: ");
            int quant = int.Parse(Console.ReadLine());

            int cont = 0;
            while (cont < quant)
            {
                Console.Write($"Value {cont + 1}: "); 
                int value = int.Parse(Console.ReadLine());
                printService.AddValeu(value);
                cont++;
            }

            printService.Print();
            Console.WriteLine($"Firts number: {printService.First()}");
        }
    }
}
