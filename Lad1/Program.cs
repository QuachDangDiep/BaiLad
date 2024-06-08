using Lad1;

class Program{
    public static void Main(){
        // declare a car object reference named myCar
        Car myCar;
        // create a Car object, and assign its address to myCar
        System.Console.WriteLine("Creating a Car object and assigning "
        + "its memory location to myCar");
        myCar = new Car();

        // assign values to th Car object's fields using myCar
        myCar.make = "Toyota";
        myCar.model = "MR2";
        myCar.color = "black";
        myCar.yearBuilt = 1995;

        // display the field values using myCar
        System.Console.WriteLine("myCar details:");
        System.Console.WriteLine("myCar.make= "+myCar.make);
        System.Console.WriteLine("mycar.model= "+myCar.color);
        System.Console.WriteLine("myCar.yearBuilt= " +myCar.yearBuilt);

        // call the methos using myCar
        myCar.start();
        myCar.stop();

        //declare anotther Car object reference and 
        // create anotther Car object
        System.Console.WriteLine("Creating anothor Car object and"
        +"assigning its memory location to redPorsche");
        Car redPorsche = new Car();
        redPorsche.make = "Porsche";
        redPorsche.model = "Boxster";
        redPorsche.color = "Red";
        redPorsche.yearBuilt = 2000;
        System.Console.WriteLine("redPorsche is a "+ redPorsche.model);
        //change the object referenced by the myCar object 
        //reference to the referenced by redPorsche
        System.Console.WriteLine("Assigning redPorsche to myCar");
        myCar = redPorsche;
        System.Console.WriteLine("mycar details:");
        System.Console.WriteLine("myCar.make = " + myCar.make); 
        System.Console.WriteLine("myCar.model = " + myCar.model); 
        System.Console.WriteLine("myCar.color = " + myCar.color); 
        System.Console.WriteLine("myCar.yearBuilt = "+ myCar.yearBuilt);
        // assign null to myCar (myCar will no longer reference
        // an object)
        myCar = null;
        Console.ReadLine(); 
    }
}