using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_3.Models.Vehicles.Cars;

namespace Module_2_Practice_3.Models
{
    public class TaxiCompany : ICloneable
    {
        public TaxiCompany()
        {
        }

        public TaxiCompany(Car[] cars)
        {
            Cars = cars;
        }

        public Car[] Cars { get; set; }

        public object Clone()
        {
            return new TaxiCompany(Cars);
        }
    }
}
