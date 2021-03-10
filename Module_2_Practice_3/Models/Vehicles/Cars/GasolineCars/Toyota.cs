using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_3.Models.Enums;

namespace Module_2_Practice_3.Models.Vehicles.Cars.GasolineCars
{
    public class Toyota : GasolineCar
    {
        public Toyota(double price, double topSpeed, double horsePower, double fuelConsumptionMilesPerGallon, ToyotaModel model)
            : base(price, topSpeed, horsePower, fuelConsumptionMilesPerGallon)
        {
            Model = model;
        }

        public override double Price { get; set; }

        public override double TopSpeed { get; set; }

        public override double HorsePower { get; set; }

        public override double FuelConsumptionMilesPerGallon { get; set; }

        public ToyotaModel Model { get; set; }

        public override int PassengerSeats { get; } = 5;

        public override ManufacturerCompany Manufacturer { get; } = ManufacturerCompany.Toyota;
    }
}
