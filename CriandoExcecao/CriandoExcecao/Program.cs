using System;
using CriandoExcecao.Entities;
using CriandoExcecao.Entities.Exceptions;

namespace CriandoExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                /*Solução muito ruim  1 
                if (checkOut <= checkIn) {
                    Console.WriteLine("Error in reservation: check-out date most be after check-in");
                }
                else
                {*/

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("\nEnter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                /*
                 *Solção muito ruim 1
                 * 
                 * DateTime now = DateTime.Now;
                 if (checkIn < now || checkOut < now)
                 {
                     Console.WriteLine("error in reservation: reservation dates for update must be future dates");
                 }
                 else if (checkOut <= checkIn)
                 {
                     Console.WriteLine("Error in reservation: check-out date most be after check-in");

                 }*/

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error in Resevation : "+ e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error : "+e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error : "+ e.Message);
            }
        }
    }
}

