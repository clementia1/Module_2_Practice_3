using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice_3.Models.Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double price, double topSpeed, double powerKilowatts)
        {
            Price = price;
            TopSpeed = topSpeed;
            PowerKilowatts = powerKilowatts;
        }

        public abstract double Price { get; set; }

        public abstract double TopSpeed { get; set; }

        public abstract double PowerKilowatts { get; set; }

        public abstract double FuelConsumptionMilesPerGallon { get; set; }
    }
}
