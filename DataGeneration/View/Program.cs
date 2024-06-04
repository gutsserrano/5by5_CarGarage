using Models;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void GenerateCar()
        {
            Random randon = new Random();
            string[] cars = { "Volkswagen Gol", "Fiat Uno", "Chevrolet Onix", "Ford Fiesta", "Renault Sandero", "Hyundai HB20", "Toyota Corolla", "Honda Civic", "Fiat Palio", "Volkswagen Fox", "Chevrolet Corsa", "Ford Ka", "Renault Logan", "Nissan Versa", "Toyota Hilux", "Honda Fit", "Volkswagen Saveiro", "Fiat Strada", "Chevrolet Prisma", "Ford Focus", "Hyundai Creta", "Toyota Etios", "Renault Duster", "Nissan March", "Volkswagen Voyage", "Fiat Siena", "Chevrolet Cruze", "Honda HR-V", "Ford Ranger", "Toyota RAV4", "Volkswagen Polo", "Fiat Argo", "Renault Kwid", "Nissan Kicks", "Hyundai Tucson", "Chevrolet Spin", "Honda City", "Ford Ecosport", "Toyota Yaris", "Volkswagen Jetta", "Fiat Fiorino", "Renault Captur", "Nissan Sentra", "Hyundai i30", "Chevrolet Tracker", "Ford Fusion", "Toyota SW4", "Volkswagen Amarok", "Fiat Toro", "Renault Fluence", "Honda Accord", "Chevrolet Cobalt", "Ford Edge", "Toyota Camry", "Volkswagen Golf", "Fiat Mobi", "Renault Megane", "Nissan Frontier", "Hyundai Santa Fe", "Chevrolet Montana", "Ford Territory", "Toyota Prius", "Volkswagen Up!", "Fiat Grand Siena", "Renault Oroch", "Nissan Tiida", "Hyundai Veloster", "Chevrolet Trailblazer", "Ford Taurus", "Toyota Land Cruiser", "Volkswagen SpaceFox", "Fiat Cronos", "Renault Symbol", "Nissan X-Trail", "Hyundai Elantra", "Chevrolet S10", "Ford Mustang", "Toyota Hilux SW4", "Volkswagen Tiguan", "Fiat Doblo", "Renault Scenic", "Nissan Altima", "Hyundai Genesis", "Chevrolet Camaro", "Ford Explorer", "Toyota Prius C", "Volkswagen Passat", "Fiat 500", "Renault Zoe", "Nissan Murano", "Hyundai Azera", "Chevrolet Equinox", "Ford F-150", "Toyota Avalon", "Volkswagen Virtus", "Fiat 147", "Renault Twingo", "Nissan Maxima", "Hyundai Veracruz", "Chevrolet Blazer" };
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Car car = new Car()
            {
                Plate = $"{letters[randon.Next(0, letters.Length)]}{letters[randon.Next(0, letters.Length)]}{letters[randon.Next(0, letters.Length)]}-{randon.Next(0,100):000}",
                Name = cars[randon.Next(0, cars.Length)],
            };
        }
    }
}
