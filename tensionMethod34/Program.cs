using ExtensionMethod34.Extensions;
// Importa o namespace onde estão definidas as extensões (`ElapsedTime` e `Cut`).

namespace ExtensionMethod34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria um objeto DateTime com uma data e hora específicas.
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);

            // Chama o método de extensão `ElapsedTime` definido na classe `DateTimeExtensions`.
            // Este método calcula o tempo decorrido desde a data armazenada em 'dt' até o momento atual.
            Console.WriteLine(dt.ElapsedTime());

            // Cria uma string com o texto "Good morning dear students!".
            String s1 = "Good morning dear students!";

            // Chama o método de extensão `Cut` definido na classe `StringExtensions`.
            // Este método retorna os primeiros 10 caracteres da string e adiciona "..." caso o comprimento exceda 10.
            Console.WriteLine(s1.Cut(10));
        }
    }
}
