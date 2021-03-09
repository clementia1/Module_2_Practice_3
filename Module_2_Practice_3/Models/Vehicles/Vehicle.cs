using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice_3.Models.Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double price, double topSpeed, double horsePower)
        {
            Price = price;
            TopSpeed = topSpeed;
            HorsePower = horsePower;
        }

        public abstract double Price { get; set; }

        public abstract double TopSpeed { get; set; }

        public abstract double HorsePower { get; set; }

        public abstract double FuelConsumptionMilesPerGallon { get; set; }
    }
}
