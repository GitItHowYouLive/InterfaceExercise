using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public bool IsLifted { get; set; }
        public string BedType { get; set; }

        public string Slogan { get; set; }
        public double ConsumerRating { get; set; }
        public void Horn()
        {
            Console.WriteLine("HONK HONK");
        }
        public void Drive()
        {
            Console.WriteLine("RUHBUHRUHBUHRUHBUHRUHBUHRUHBUHRUHBUH");
        }
        public int Wheels { get; set; }
        public string Engine { get; set; }

    }
}
