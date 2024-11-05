using ExExcecoes21.Entities.Exceptions;
using System;

namespace ExExcecoes21.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            // Verifica se a data de check-out é antes ou igual ao check-in
            if (checkOut <= checkIn)
            {
                // Lança uma exceção personalizada se a condição não for atendida
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void RegisterReservation()
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;

            // Verifica se as datas estão no futuro
            if (checkIn < now || checkOut < now)
            {
                // Lança uma exceção personalizada se a reserva tiver datas passadas
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if (checkOut <= checkIn)
            {
                // Verifica novamente se o check-out é posterior ao check-in e lança uma exceção se não for
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = number;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Console.WriteLine("Reservation: " + ToString());
        }

        public void RegisterUpdate()
        {
            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation:");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;

            // Verifica se as novas datas para atualização estão no futuro
            if (checkIn < now || checkOut < now)
            {
                // Lança uma exceção personalizada caso a data de atualização seja inválida
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if (checkOut <= checkIn)
            {
                // Verifica se o check-out é posterior ao check-in e lança uma exceção se não for
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            Console.WriteLine("Reservation update: " + ToString());
        }

        public double Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber +
                " - Check in: " + CheckIn.ToString("dd/MM/yyyy") +
                " - Check out: " + CheckOut.ToString("dd/MM/yyyy") +
                " - " + Duration() + " nights";
        }
    }
}
