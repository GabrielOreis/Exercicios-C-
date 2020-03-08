using System;
using CriandoExcecao.Entities.Exceptions;

namespace CriandoExcecao.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("check -out date most be after check-in");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public Reservation()
        {
        }

        public int Duration() {

            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;  
        }

        public void UpdateDates(DateTime checkIn , DateTime checkOut)
        {
            /*Solução ruim 2
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return " reservation dates for update must be future dates";
            }
            if (checkOut <= checkIn)
            {
                return " check-out date most be after check-in";
            }*/

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException(" reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("check -out date most be after check-in");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            //não precisa mais retorna nulo
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy")
                   + ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights";
        }
    }
}
