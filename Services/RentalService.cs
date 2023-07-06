using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterAppOne.Entities;

namespace InterAppOne.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        // dependecia
        private ITaxService _taxService; 

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;

            // O que foi feito abaixo é chamado de
            // inversão de controle por meio de injeção de dependências. 
            _taxService = taxService;

            // Ou seja, ela não mais instancia a dependência dela
            // recebendo o objeto instanciado e atribuir.
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12)
            {
                // A superclasse Math, tem um método chamado Ceiling,
                // que arredonda valores pra cima
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
