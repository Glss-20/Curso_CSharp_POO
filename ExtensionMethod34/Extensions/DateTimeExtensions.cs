using System; // Necessário para trabalhar com tipos básicos, como DateTime e TimeSpan.
using System.Globalization; // Fornece suporte a formatação cultural, usado aqui para formatar números.

namespace ExtensionMethod34.Extensions
{
    static class DateTimeExtensions
    {
        // Define um método de extensão chamado `ElapsedTime` para o tipo `DateTime`.
        public static string ElapsedTime(this DateTime thisObj)
        {
            // Calcula a diferença entre o momento atual (DateTime.Now) e o objeto DateTime `thisObj`.
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            // Verifica se o tempo decorrido é menor que 24 horas.
            if (duration.TotalHours < 24.0)
            {
                // Se for menor, retorna o tempo decorrido em horas, formatado com 1 casa decimal.
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                // Caso contrário, retorna o tempo decorrido em dias, formatado com 1 casa decimal.
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
