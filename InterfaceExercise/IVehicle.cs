using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfDoors { get; set; }

        public int PeopleCapacity { get; set; }

        public int NumberOfWheels { get; set; }

        public bool IsAutomatic { get; set; }

        public void PrintVehicleInfo();

    }
}