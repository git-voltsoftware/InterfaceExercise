using System;
using System.Drawing;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Make = "Ford",
                Model = "Mustang",
                Year = 2023,
                MilesPerGallon = 23,
                Color = "Red",
                DriveType = "2WD",
                Wheels = 4
            };

            Truck truck1 = new Truck
            {
                Make = "Ford",
                Model = "F-150",
                Year = 2023,
                Color = "Silver",
                DriveType = "4WD",
                Wheels = 4,
                BedSize = 5.11
            };

            SUV suv1 = new SUV
            {
                Make = "Ford",
                Model = "F-150",
                Year = 2023,
                Color = "Silver",
                NumberOfSeats = 8,
                DriveType = "4WD",
                Wheels = 4
            };

            Console.WriteLine($"So I hit the lottery and bought a {car1.Make} {car1.Model} for off roading I bought a {truck1.Make} {truck1.Model} and for the family long rides I bought a {suv1.Make} {suv1.Model}.");
            Console.ReadKey();
        }

        public interface IVehicle
        {
            string Color { get; set; }
            string DriveType { get; set; }
            int Wheels { get; set; }
        }

        public interface ICompany
        {
            string Make { get; set; }
            string Model { get; set; }
            int Year { get; set; }
        }
    }
}
