using System;
using System.Collections.Generic;
namespace PolymorphismExample
{
    class Vehicle
    {
        public virtual int Wheels()
        {
            return 10;
        }
    }
    class car : Vehicle
    {
        public override int Wheels()
        {
            return 4;
        }
    }
    class bike : Vehicle
    {
        public new int Wheels()
        {
            return 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle());
            vehicles.Add(new car());          //rectangle that has been cast as a polygon
            vehicles.Add(new bike());           //triangle that has been cast as a polygon

            int numWheels = 0;

            foreach (Vehicle p in vehicles)
            {
                numWheels = p.Wheels();
                Console.WriteLine( "Number of wheels" + numWheels);
            }
            bike bike1 = new bike();
            numWheels = bike1.Wheels();
            Console.WriteLine("Number of wheels" + numWheels);
        }
    }
}
