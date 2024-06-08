using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lad6
{
    class Heater
    {
       public Heater(float temperature){
        temperature = temperature;
       }   
       public float Temperature{
        get{
            return _temperature;
        }
        set{
            _temperature = value;
        }
        }
        private float _Temperature;
        public void OnTemperratureChanged(float newTemperature){
            if(newTemperature < Temperature){
                System.Console.WriteLine("Heater: On");
            }
            else{
                System.Console.WriteLine("Heater: Off");
            }
        }
    }
}