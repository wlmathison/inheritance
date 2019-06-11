using System;
using System.Collections.Generic;

namespace inheritance
{
    public class BatteryStation
    {
        public int capacity { get; set; }

        public void Refuel(List<IElectricVehicle> vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"The {vehicle.Type} has been recharged using {capacity} KWh.");
            }
        }
    }
}