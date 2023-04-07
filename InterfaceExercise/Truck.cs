using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterfaceExercise.Program;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Wheels { get; set; }
        public double BedSize { get; set; }
        public string Color { get; set; }
        public string DriveType { get; set; }


    }
}
