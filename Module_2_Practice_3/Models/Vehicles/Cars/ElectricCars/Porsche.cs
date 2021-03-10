using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_3.Models.Enums;

namespace Module_2_Practice_3.Models.Vehicles.Cars.ElectricCars
{
    public class Porsche : ElectricCar
    {
        public Porsche(double price, double topSpeed, double horsePower, double energyConsumptionWattHoursPerKilometer, PorscheModel model)
            : base(price, topSpeed, horsePower, energyConsumptionWattHoursPerKilometer)
        {
            Model = model;
        }

        public override double Price { get; set; }

        public override double TopSpeed { get; set; }

        public override double HorsePower { get; set; }

        public override double EnergyConsumptionWattHoursPerKilometer { get; set; }

        public override double FuelConsumptionMilesPerGallon { get; set; }

        public PorscheModel Model { get; set; }

        public override int PassengerSeats { get; } = 4;

        public override ManufacturerCompany Manufacturer { get; } = ManufacturerCompany.Porsche;
    }
}
