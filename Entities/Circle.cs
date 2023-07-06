using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterAppOne.Entities
{
    class Circle : AbstractShape
    {
        public double radius { get; set; }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"Circle color: {Color}, " +
                $"Radius: {radius.ToString("F2",CultureInfo.InvariantCulture)}," +
                $"Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}
