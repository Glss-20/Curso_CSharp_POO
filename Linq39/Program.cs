using System;
using Linq39.Entities;
using System.Linq;

namespace Linq39
{
    class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 1 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 2 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 3 };

            List<Product> list = new List<Product>()
            {
                new Product() {Id = 1, Name = "Computer", Price = 1100, Category = c2},
                new Product() {Id = 2, Name = "Hammer", Price = 90, Category = c1},
                new Product() {Id = 3, Name = "Tv", Price = 1700, Category = c3},
                new Product() {Id = 4, Name = "Notebook", Price = 1300, Category = c2},
                new Product() {Id = 5, Name = "Saw", Price = 80, Category = c1},
                new Product() {Id = 6, Name = "Tablet", Price = 700, Category = c2},
                new Product() {Id = 7, Name = "Camera", Price = 700, Category = c3},
                new Product() {Id = 8, Name = "Printer", Price = 350, Category = c3},
                new Product() {Id = 9, Name = "Macbook", Price = 1800, Category = c2},
                new Product() {Id = 10, Name = "SoundBar", Price = 700, Category = c3},
                new Product() {Id = 11, Name = "Level", Price = 70, Category = c1},
            };

            var consult1 = list.Where(p => p.Category.Tier == 2 && p.Price < 900);
            // Filtra os produtos cuja categoria tem Tier 2 e preço inferior a 900.

            Console.WriteLine("TIER 2 AND PRICE < 900.00");

            foreach (Product p1 in consult1)
            {
                Console.WriteLine(p1);
            }

            var consult2 = list.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            // Filtra os produtos da categoria "Tools" e retorna apenas os nomes desses produtos.

            Console.WriteLine("CATEGORY TOOLS");

            foreach (string p2 in consult2)
            {
                Console.WriteLine(p2);
            };

            var consult3 = list.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            // Filtra os produtos cujo nome começa com a letra 'C' e cria um objeto anônimo contendo o nome, preço e nome da categoria.

            Console.WriteLine("NAMES STARDED WITH 'C' ");

            foreach (var p3 in consult3)
            {
                Console.WriteLine(p3);
            };

            var consult4 = list.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            // Filtra os produtos da categoria Tier 1 e os ordena primeiro pelo preço e, em seguida, pelo nome.

            Console.WriteLine("PRODUCTS TIER 1 ORDER");

            foreach (var p4 in consult4)
            {
                Console.WriteLine(p4);
            }

            var consult5 = consult4.Skip(2).Take(4);
            // Ignora os dois primeiros produtos da consulta anterior e seleciona os próximos quatro.

            Console.WriteLine("SKIP TWO");

            foreach (var p5 in consult5)
            {
                Console.WriteLine(p5);
            }

            var consult6 = list.First();
            // Retorna o primeiro produto da lista.
            Console.WriteLine($"First test1: {consult6}");

            var consult7 = list.Where(p => p.Price > 3000.0).FirstOrDefault();
            // Retorna o primeiro produto com preço maior que 3000 ou `null` se nenhum for encontrado.
            Console.WriteLine($"First or default test1: {consult7}");

            var consult8 = list.Where(p => p.Id == 3).SingleOrDefault();
            // Retorna o único produto com Id 3, ou `null` se nenhum ou mais de um for encontrado.
            Console.WriteLine($"Single or default: {consult8}");

            var consult9 = list.Max(p => p.Price);
            // Retorna o maior preço entre todos os produtos.
            Console.WriteLine($"MAX PRICE {consult9}");

            var consult10 = list.Min(p => p.Price);
            // Retorna o menor preço entre todos os produtos.
            Console.WriteLine($"MIN PRICE {consult10}");

            var consult11 = list.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            // Soma os preços de todos os produtos cuja categoria tem Id 1.
            Console.WriteLine($"Category 1 sum prices: {consult11}");

            var consult12 = list.Where(p => p.Category.Id == 1).Average(p => p.Price);
            // Calcula a média dos preços de todos os produtos cuja categoria tem Id 1.
            Console.WriteLine($"Category 1 average prices: {consult12}");

            var consult13 = list.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            // Calcula a média dos preços dos produtos cuja categoria tem Id 5. Retorna 0.0 caso não existam produtos na categoria.
            Console.WriteLine($"Category 5 average prices: {consult13}");

            var consult14 = list.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            // Soma os preços dos produtos cuja categoria tem Id 1 usando o método Aggregate.
            Console.WriteLine($"Category 1 aggregate sum: {consult14}");

            var consult15 = list.GroupBy(p => p.Category);
            // Agrupa os produtos por categoria.
            foreach (IGrouping<Category, Product> group in consult15) // Itera sobre cada categoria.
            {
                Console.WriteLine($"Category {group.Key.Name}: ");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
