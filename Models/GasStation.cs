using System;
using System.Collections.Generic;

namespace inheritance
{
    public class GasStation : IStation<IGasVehicle>
    {
        public int capacity { get; set; }

        public void Refuel(List<IGasVehicle> vehicles)
        {
            foreach (IGasVehicle vehicle in vehicles)
            {
                Console.WriteLine($"The {vehicle.} has been refueled with {vehicle.FuelCapacity} gallons of gas.");
            }
        }
    }
}