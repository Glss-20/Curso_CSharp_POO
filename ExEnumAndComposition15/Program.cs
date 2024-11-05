using ExEnumAndComposition15.Entities;

namespace ExEnumAndComposition15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Comentario 1");
            Comment c2 = new Comment("Comentario 2");
            
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to new Zeland", "Blablablabla", 12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Comentario 3");
            Comment c4 = new Comment("Comentario 4");

            Post p2 = new Post(DateTime.Parse("28/07/2018 17:32:23"), "Nigth Forever", "Blablablabla", 32);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
