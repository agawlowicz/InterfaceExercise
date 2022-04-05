using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public string CargoHoldSize { get; set; }
        public bool HasHatchback { get; set; }

        public int NumberOfDoors { get; set; }
        public int PeopleCapacity { get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsAutomatic { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }

        // Can implement properties from IVehicle, ICompany, and this current class SUV
        public void PrintVehicleInfo()
        {
            Console.WriteLine($"This SUV's company has the following logo and slogan: {Logo}, {Slogan}");

            Console.WriteLine($"This SUV has {NumberOfDoors} doors, {NumberOfWheels} wheels, " +
                $"and a capacity of {PeopleCapacity} people.");

            if (IsAutomatic == true)
            {
                Console.WriteLine("This SUV is automatic.");
            }
            else
            {
                Console.WriteLine("This SUV is not automatic.");
            }

            Console.WriteLine((HasHatchback == true) ? "This SUV has a hatchback."
                : "This SUV does not have a hatchback.");

            Console.WriteLine($"This SUV has a cargo hold of size {CargoHoldSize}");
        }
    }
}

