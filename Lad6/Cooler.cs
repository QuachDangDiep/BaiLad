using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lad6
{
    class Cooler
    {
        public Cooler(float temperature){
            Temperature = temperature;
        }
        public float Temperature{
            get{
                return _temperature;
            }
            set{
                _temperature = value;
            }
        }
            private float _temperature;
            public void OnTemperratureChanged(float newTemperature){
                if(newTemperature > Temperature){
                    System.Console.WriteLine("Cooler: On");
                }
                else{
                    System.Console.WriteLine("Cooler: Off");
                }
            }
        
    }
}