namespace Dictonary32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de um dicionário chamado 'cookies' que associa chaves (string) a valores (string).
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            // Adiciona ou atualiza valores no dicionário:
            // A chave "user" recebe o valor "maisa".
            cookies["user"] = "maisa";
            // A chave "email" recebe o valor "maisa@gmail".
            cookies["email"] = "maisa@gmail";
            // A chave "phone" recebe o valor "99999999".
            cookies["phone"] = "99999999";

            // Exibe no console o valor associado à chave "user".
            // Neste caso, será "maisa".
            Console.WriteLine(cookies["user"]);

            // Comando comentado que, se descomentado, remove a chave "email" e seu valor associado do dicionário.
            // cookies.Remove("email");

            // Verifica se a chave "email" está presente no dicionário.
            if (cookies.ContainsKey("email"))
            {
                // Se a chave "email" existir, exibe o valor associado a ela.
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                // Se a chave "email" não existir, exibe uma mensagem informando que a chave não está presente.
                Console.WriteLine("There is no email key!");
            }

            // Exibe no console o número de pares chave-valor presentes no dicionário.
            Console.WriteLine($"Size: {cookies.Count}");

            // Exibe todos os pares chave-valor presentes no dicionário.
            Console.WriteLine("All cookies");
            foreach (KeyValuePair<string, string> cookie in cookies)
            {
                // Para cada par, imprime a chave e o valor associados.
                // Exemplo de saída: "user : maisa"
                Console.WriteLine($"{cookie.Key} : {cookie.Value}");
            }
        }
    }
}
