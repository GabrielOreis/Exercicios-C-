using System;
using TrabalhandoComIterfaces.Entities;

namespace TrabalhandoComIterfaces.Services
{
    class RentalService
    {
        public double PricePorHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _TaxService;
        public RentalService(double pricePorHour, double pricePerDay , ITaxService taxService )
        {
            PricePorHour = pricePorHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }

       public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePorHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
