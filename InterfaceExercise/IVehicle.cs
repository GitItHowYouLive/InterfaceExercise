using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public void Drive();
        public void Horn();
        public int Wheels { get; set; }
        public string Engine { get; set; }

    }
}
