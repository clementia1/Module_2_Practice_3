﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_3.Models;
using Module_2_Practice_3.Models.Vehicles.Cars;

namespace Module_2_Practice_3.Services.Abstractions
{
    public interface ITaxiCompanyService
    {
        int AddCar(TaxiCompany taxiCompany, Car car);

        double GetTotalCarCost(TaxiCompany taxiCompany);

        TaxiCompany SortByFuelConsumption(TaxiCompany taxiCompany);
    }
}
