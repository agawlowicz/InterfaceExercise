using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle -DONE

            /* Create 4 members that Car, Truck, & SUV all have in common. -DONE
             * Example: All vehicles have a number of wheels... for now.. -DONE
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

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

            myCar.PrintCompanyInfo();
            myCar.PrintVehicleInfo();

            Console.WriteLine();

            mySUV.PrintCompanyInfo();
            mySUV.PrintVehicleInfo();

            Console.WriteLine();

            myTruck.PrintCompanyInfo();
            myTruck.PrintVehicleInfo();
        }
    }
}