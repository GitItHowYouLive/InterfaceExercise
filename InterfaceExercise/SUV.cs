using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public bool ThirdRow { get; set; }
        public long TowingCapacity { get; set; }
        public string Slogan { get; set; }
        public double ConsumerRating { get; set; }
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public void Drive()
        {
            Console.WriteLine("Vruuuuuuuuhhhmmm");
        }
        public void Horn()
        {
            Console.WriteLine("Bonk Bonk");
        }
    }
}
