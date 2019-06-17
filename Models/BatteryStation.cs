using System;
using System.Collections.Generic;

namespace inheritance
{
    public class BatteryStation : IStation<IElectricVehicle>
    {
        public int capacity { get; set; }

        public void Refuel(List<IElectricVehicle> vehicles)
        {
            foreach (IElectricVehicle vehicle in vehicles)
            {
                Console.WriteLine($"The {vehicle.Type} has been recharged using {vehicle.BatteryKWh} KWh.");
            }
        }
    }
}