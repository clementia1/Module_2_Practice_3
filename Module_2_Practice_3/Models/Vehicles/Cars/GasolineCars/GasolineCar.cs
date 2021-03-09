using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice_3.Models.Vehicles.Cars.GasolineCars
{
    public abstract class GasolineCar : Car
    {
        public GasolineCar(double price, double topSpeed, double horsePower, double fuelConsumptionMilesPerGallon)
            : base(price, topSpeed, horsePower)
        {
            FuelConsumptionMilesPerGallon = fuelConsumptionMilesPerGallon;
        }
    }
}
