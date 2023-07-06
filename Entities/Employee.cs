﻿using System;
using System.Globalization;
namespace InterAppOne.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing Error: Argment is not an employee");
            }
            Employee other = obj as Employee;
            // nota: você pode também comparar por salário,]
            // trocando o Name abaixo por "salary" :)
            return Name.CompareTo(other.Name);
        }
    }
}
