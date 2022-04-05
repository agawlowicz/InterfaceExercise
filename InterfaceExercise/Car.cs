using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; }
        public bool HasSunroof { get; set; }

        public int NumberOfDoors { get; set; }
        public int PeopleCapacity { get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsAutomatic { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }

        public void PrintCompanyInfo()
        {
            Console.WriteLine($"This car's company has the following logo and slogan: {Logo}, {Slogan}");
        }

        public void PrintVehicleInfo()
        {
            Console.WriteLine($"This car has {NumberOfDoors} doors, {NumberOfWheels} wheels, " +
                $"and a capacity of {PeopleCapacity} people.");

            if(IsAutomatic == true)
            {
                Console.WriteLine("This car is automatic.");
            }
            else
            {
                Console.WriteLine("This car is not automatic.");
            }

            Console.WriteLine((HasSunroof == true) ? "This car has a sunroof." : "This car does not have a sunroof.");

            Console.WriteLine(HasTrunk == true ? "This car has a trunk." : "This car does not have a trunk.");
        }
    }
}

