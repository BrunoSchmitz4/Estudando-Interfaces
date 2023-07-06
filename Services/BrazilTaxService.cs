using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterAppOne.Services
{
    // Difrente do que foi visto anteriormente,
    // Isso se chama realização de interface, e não herança
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if(amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
