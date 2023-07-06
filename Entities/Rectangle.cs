using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace InterAppOne.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Rectangle color: {Color}, Width: {Width.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" Height: {Height.ToString("F2", CultureInfo.InvariantCulture)}, Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}