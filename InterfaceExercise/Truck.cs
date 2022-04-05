using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public string BedSize { get; set; }
        public bool HasEnclosedTruckBed { get; set; }

        public int NumberOfDoors { get; set; }
        public int PeopleCapacity { get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsAutomatic { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }

        public void PrintVehicleInfo()
        {
            Console.WriteLine($"This truck's company has the following logo and slogan: {Logo}, {Slogan}");

            Console.WriteLine($"This truck has {NumberOfDoors} doors, {NumberOfWheels} wheels, " +
                $"and a capacity of {PeopleCapacity} people.");

            if (IsAutomatic == true)
            {
                Console.WriteLine("This truck is automatic.");
            }
            else
            {
                Console.WriteLine("This truck is not automatic.");
            }

            Console.WriteLine( HasEnclosedTruckBed == true ? "This truck has an enclosed truck bed."
                : "This truck does not have an enclosed truck bed.");

            Console.WriteLine($"This truck has a bed the size of {BedSize}.");
        }
    }
}

