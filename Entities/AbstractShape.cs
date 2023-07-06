using System;
using System.Collections.Generic;
using InterAppOne.Enums;
namespace InterAppOne.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
