using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_3.Models.Enums;

namespace Module_2_Practice_3.Models.Vehicles.Cars.ElectricCars
{
    public class Tesla : ElectricCar
    {
        public Tesla(double price, double topSpeed, double powerKilowatts, int energyConsumptionWattHoursPerKilometer)
            : base(price, topSpeed, powerKilowatts, energyConsumptionWattHoursPerKilometer)
        {
        }

        public override double Price { get; set; }

        public override double TopSpeed { get; set; }

        public override double PowerKilowatts { get; set; }

        public override int EnergyConsumptionWattHoursPerKilometer { get; set; }

        public TeslaModel Model { get; set; }
    }
}
