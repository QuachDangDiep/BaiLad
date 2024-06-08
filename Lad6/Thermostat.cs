using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lad6
{
    class Thermostat
    {
        public delegate void TemperatureChangeHaandler(float newTemperature);

        // Define the event publisher
        private TemperatureChangeHaandler _OnTemperatureChange;
        public TemperatureChangeHaandler OnTemperratureChange
        {
            get
            {
                return _OnTemperatureChange;
            }
            set
            {
                _OnTemperatureChange = value;
            }
        }
        public float CurrentTemperature{
            get{ return _CurrentTemperature; }
            set{
                if(value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    if(OnTemperratureChange!= null){
                        OnTemperratureChange(value);
                    }
                }
            }
        }    
    }
    private float _CurrentTemperature;
}