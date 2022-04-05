using System;
namespace InterfaceExercise
{
    public interface IVehicle //all memebers of interface are automatically abstract
    {
        public int NumberOfDoors { get; set; } //can't set default values

        public int PeopleCapacity { get; set; }

        public int NumberOfWheels { get; set; }

        public bool IsAutomatic { get; set; }

        public void PrintVehicleInfo();

    }
}