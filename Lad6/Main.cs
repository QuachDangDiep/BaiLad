using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Lad6
{
    class Main
    {
        static void Main(string[] args){
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            thermostat.OnTemperratureChange += heater.OnTemperratureChanged;
            Heater heaterCuong = new Heater(100);
            thermostat.OnTemperratureChange += heaterCuong.OnTemperratureChanged;

            Cooler cooler = new Cooler(80);
            thermostat.OnTemperratureChange += cooler.OnTemperratureChanged;
            string temperature;
            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
            Console.ReadLine();
        }        
    }
}