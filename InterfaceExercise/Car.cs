using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public int TopSpeed { get; set; }
        public bool Convertible { get; set; }
        public int Wheels { get; set; }
        public string Engine { get; set; }
        public void Drive()
        {
            Console.WriteLine("Vroom!");
        }

        public void Horn()
        {
            Console.WriteLine("beep beep");
        }

        public string Slogan { get; set; }
        public double ConsumerRating { get; set; }
    }
}
