using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice_3.Models.Vehicles.Cars.ElectricCars
{
    public abstract class ElectricCar : Car
    {
        public ElectricCar(double price, double topSpeed, double powerKilowatts, int energyConsumptionWattHoursPerKilometer)
            : base(price, topSpeed, powerKilowatts)
        {
            EnergyConsumptionWattHoursPerKilometer = energyConsumptionWattHoursPerKilometer;
            FuelConsumptionMilesPerGallon = ConvertEnergyConsuptionToGasoline(energyConsumptionWattHoursPerKilometer);
        }

        public abstract int EnergyConsumptionWattHoursPerKilometer { get; set; }

        public double ConvertEnergyConsuptionToGasoline(double wattHourPerKilometer)
        {
            return 3370.5 / 1.609344 / wattHourPerKilometer * 10;
        }
    }
}
