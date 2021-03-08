using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_3.Models.Vehicles.Cars;

namespace Module_2_Practice_3.Helpers
{
    public class SortCarsByFuelConsumptionDescending : IComparer<Car>
    {
        public int Compare(Car a, Car b)
        {
            if (a.FuelConsumptionMilesPerGallon > b.FuelConsumptionMilesPerGallon)
            {
                return 1;
            }

            if (a.FuelConsumptionMilesPerGallon < b.FuelConsumptionMilesPerGallon)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
