using System;

namespace carproj
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Vehicle(2);
            Vehicle myBike = new Vehicle(1);
            Console.WriteLine(myCar.numPassengers);
            System.Console.WriteLine(myBike.numPassengers);
        }
    }
}
