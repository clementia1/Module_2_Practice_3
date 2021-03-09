using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_3.Models;
using Module_2_Practice_3.Models.Vehicles.Cars;
using Module_2_Practice_3.Services.Abstractions;
using Module_2_Practice_3.Services;
using Module_2_Practice_3.Models.Vehicles.Cars.ElectricCars;
using Module_2_Practice_3.Models.Vehicles.Cars.GasolineCars;
using Module_2_Practice_3.Models.Enums;

namespace Module_2_Practice_3
{
    public class Starter
    {
        public void Run()
        {
            var taxiCompany = new TaxiCompany();
            var taxiCompanyService = new TaxiCompanyService();
            taxiCompany.Cars = new Car[5];

            taxiCompanyService.AddCar(taxiCompany, new Tesla(45000, 225, 480, 149, TeslaModel.Model3));
            taxiCompanyService.AddCar(taxiCompany, new Tesla(141005, 322, 1020, 172, TeslaModel.ModelS));
            taxiCompanyService.AddCar(taxiCompany, new Porsche(186336, 260, 402, 215, PorscheModel.Taycan));
            taxiCompanyService.AddCar(taxiCompany, new Toyota(26170, 210, 203, 32, ToyotaModel.Camry));

            var sortedByFuelConsuption = taxiCompanyService.SortByFuelConsumptionDescending(taxiCompany);
            var carsTotalValue = taxiCompanyService.GetTotalCarCost(taxiCompany);
            var filteredByHorsePower = taxiCompanyService.FilterByPower(taxiCompany, 30, 50);
        }
    }
}
