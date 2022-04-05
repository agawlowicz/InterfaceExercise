using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car()
            {
                HasSunroof = true,
                HasTrunk = true,

                NumberOfDoors = 4,
                PeopleCapacity = 5,
                NumberOfWheels = 4,
                IsAutomatic = true,

                Logo = "Lightning",
                Slogan = "Be Fast!"
            };

            var myTruck = new Truck()
            {
                BedSize = "very large",
                HasEnclosedTruckBed = false,

                NumberOfDoors = 4,
                PeopleCapacity = 8,     // including using the bed, maybe not safe though
                NumberOfWheels = 4,
                IsAutomatic = false,

                Logo = "Zebra",
                Slogan = "Be different!"
            };

            var mySUV = new SUV()
            {
                CargoHoldSize = "a ton of stuff",
                HasHatchback = true,

                NumberOfDoors = 4,
                PeopleCapacity = 7,
                NumberOfWheels = 4,
                IsAutomatic = true,

                Logo = "Camel",
                Slogan = "Store everything!"
            };

            /* Review Example
             * var vehicleList = new List<IVehicle> { myCar, myTruck, mySUV };

            foreach(var car in vehicleList)
            {
                Console.WriteLine($"Vehicle has {car.NumberOfDoors} doors, " +
                    $"{car.NumberOfWheels} wheels, and a people capacity of {car.PeopleCapacity}");
            } */

            
            myCar.PrintVehicleInfo();

            Console.WriteLine();

            mySUV.PrintVehicleInfo();

            Console.WriteLine();

            myTruck.PrintVehicleInfo();
            
        }
    }
}