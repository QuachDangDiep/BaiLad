using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lad1
{
     class Car
    {
        public string make;
        public string model;
        public string color;
        public int yearBuilt;
        public void start(){
            System.Console.WriteLine(model + "started");
        }
        public void stop(){
            System.Console.WriteLine(model + "stopped");
        }
    }
}