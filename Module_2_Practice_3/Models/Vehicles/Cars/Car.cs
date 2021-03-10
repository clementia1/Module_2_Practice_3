using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_3.Models.Enums;

namespace Module_2_Practice_3.Models.Vehicles.Cars
{
    public abstract class Car : Vehicle
    {
        public Car(double price, double topSpeed, double horsePower)
            : base(price, topSpeed, horsePower)
        {
        }

        public abstract int PassengerSeats { get; }

        public abstract ManufacturerCompany Manufacturer { get; }
    }
}
