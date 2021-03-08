using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_3.Services.Abstractions;
using Module_2_Practice_3.Models.Enums;

namespace Module_2_Practice_3.Models.Vehicles.Cars.ElectricCars
{
    public class TeslaFactory : ICarFactory
    {
        private double _price;
        private double _topSpeed;
        private double _powerKilowatts;
        private int _energyConsumptionWattHoursPerKilometer;
        private TeslaModel _model;

        public TeslaFactory()
        {
        }

        public override double Price { get; set; }

        public override double TopSpeed { get; set; }

        public override double PowerKilowatts { get; set; }

        public override int EnergyConsumptionWattHoursPerKilometer { get; set; }

        public TeslaModel Model { get; set; }
        public Car CreateCar()
        {
            return new Tesla();
        }
    }
}
