using ExExcecoes21.Entities.Exceptions;
using ExExcecoes21.Entities;

namespace ExExcecoes21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Reservation reservation = new Reservation();
                reservation.RegisterReservation();
                reservation.RegisterUpdate();
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
                // Exceção personalisada.
                // "e.Message" vai puxar a mensagem do DomainException específico definido nos métodos.
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
                // Exceção de sistema.
                // "e.Message" vai puxar a mensagem da exceção de FormatException, que já é uma mensagem definada pelo .NET

            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
