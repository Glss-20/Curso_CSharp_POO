using System; // Necessário para trabalhar com tipos básicos, como strings.

namespace ExtensionMethod34.Extensions
{
    static class StringExtensions
    {
        // Define um método de extensão chamado `Cut` para o tipo `string`.
        public static string Cut(this string thisObj, int count)
        {
            // Verifica se o comprimento da string é menor ou igual ao número de caracteres desejado.
            if (thisObj.Length <= count)
            {
                // Se for, retorna a string inteira.
                return thisObj;
            }
            else
            {
                // Caso contrário, retorna apenas os primeiros `count` caracteres, seguidos de "...".
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
