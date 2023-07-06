using InterAppOne.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Transactions;
using InterAppOne.Services;

namespace InterAppOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles();
        }

        static void Vehicles()
        {
            Console.WriteLine("Dados do Veículo: ");
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.Write("Data e Hora de Entrada (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data e Hora de Saída (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Insira o preço por hora: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);Console.WriteLine("Insira o preço por hora: ");
            
            Console.Write("Insira o preço por dia: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.Write("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
        
        static void InitGeometricsF()
        {
            

            try
            {
                string option = "".ToUpper();
                option.ToUpper();
                while ((option != "C") || (option != "Q") 
                    || (option != "R") || (option != "T"))
                {
                    Console.WriteLine("Option foi salvo com um: " + option);
                    Console.WriteLine("Selecione uma forma geométrica das abaixo:");
                    Console.Write("(C) - Círculo | (Q) - Quadrado | " +
                        "(R) - Retângulo | (T) - Triângulo: ");
                    option = Console.ReadLine().ToUpper();
                    option.ToUpper();
                    if (option == "C")
                    {
                        Console.WriteLine("Escolheu círculo");
                    }
                    else if (option == "R")
                    {
                        Console.WriteLine("Escolheu retângulo");
                    }
                    else if (option == "T")
                    {
                        Console.WriteLine("Escolheu triângulo");

                    }
                    else if (option == "Q")
                    {
                        Console.WriteLine("Escolheu quadrado");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}