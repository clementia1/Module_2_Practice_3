using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_3.Helpers.Comparers;
using Module_2_Practice_3.Models;
using Module_2_Practice_3.Models.Vehicles.Cars;
using Module_2_Practice_3.Services.Abstractions;

namespace Module_2_Practice_3.Services
{
    public class TaxiCompanyService : ITaxiCompanyService
    {
        public int AddCar(TaxiCompany taxiCompany, Car car)
        {
            var index = Array.IndexOf(taxiCompany.Cars, default(Car));

            if (index != -1)
            {
                taxiCompany.Cars[index] = car;
            }

            return index;
        }

        public double GetTotalCarCost(TaxiCompany taxiCompany)
        {
            double sum = 0;

            foreach (var item in taxiCompany.Cars)
            {
                sum += item.Price;
            }

            return sum;
        }

        public TaxiCompany SortByFuelConsumptionDescending(TaxiCompany taxiCompany)
        {
            var result = (TaxiCompany)taxiCompany.Clone();
            Array.Sort(result.Cars, new SortCarsByFuelConsumptionDescending());
            return result;
        }

        public TaxiCompany FilterByPrice(TaxiCompany taxiCompany, double minPrice, double maxPrice)
        {
            var result = (TaxiCompany)taxiCompany.Clone();
            result.Cars = Array.FindAll(taxiCompany.Cars, item => item.Price > minPrice && item.Price < maxPrice);
            return result;
        }

        public TaxiCompany FilterByPower(TaxiCompany taxiCompany, double minPower, double maxPower)
        {
            var result = (TaxiCompany)taxiCompany.Clone();
            result.Cars = Array.FindAll(taxiCompany.Cars, item => item.HorsePower > minPower && item.HorsePower < maxPower);
            return result;
        }

        public TaxiCompany FilterByFuelConsumption(TaxiCompany taxiCompany, double minFuelConsumption, double maxFuelConsumption)
        {
            var result = (TaxiCompany)taxiCompany.Clone();
            result.Cars = Array.FindAll(taxiCompany.Cars, item => item.FuelConsumptionMilesPerGallon > minFuelConsumption && item.FuelConsumptionMilesPerGallon < maxFuelConsumption);
            return result;
        }
    }
}
