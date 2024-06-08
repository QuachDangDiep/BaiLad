using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lad4
{
    public abstract class Geometricobject
    {
         protected string color;
         protected double weight;
         // Default constructor
         protected Geometricobject(){
            color = "white";
            weight = 1.0;
         }
         // Construct a geometic object
         protected Geometricobject(string color, double weight){
            this.color = color;
            this.weight = weight;
         }
         //properties
         public string PColor{
            get{return color;}
            set{color = value;}
         }
         public double PWeight{
            get{return weight;}
            set{weight = value;}
         }
         // abstract method
         public abstract double findArea();
         // abstract method
         public abstract double findPerimeter();
    }
}