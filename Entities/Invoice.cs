using System;
using System.Collections.Generic;
using System.Globalization;

namespace InterAppOne.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }


        // Retornar para double se necessário
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic payment: R$ {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}%\n" +
                $"Total payment: R$ " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
