using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS___Assessment_3.Classes
{
    class Vehicle
    {
        //for consistency I make the start of every word in the variables begin with capitals. First, First_Name.
        string Manufacturer { get; set; }
        string Model { get; set; }
        string Make_Year { get; set; }
        string Registration { get; set; }
        double Kilometers_Travelled { get; set; }
        int Total_Services { get; set; }
        double Fuel_Economy { get; set; }
        bool Requires_Service { get; set; }
        double Fuel_Used { get; set; }
        //Upper case beginnings then lower case beginnings
        public Vehicle(string manufacturer, string model, string make_year, string registration, double kilometers_travelled, int total_services, double fuel_economy, bool requires_service, double fuel_used)
        {
            Manufacturer = manufacturer;
            Model = model;
            Make_Year = make_year;
            Registration = registration;
            Kilometers_Travelled = kilometers_travelled;
            Total_Services = total_services;
            Fuel_Economy = fuel_economy;
            Requires_Service = requires_service;
            Fuel_Used = fuel_used;
        }
    }

}
