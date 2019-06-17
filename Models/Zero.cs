using System;

namespace inheritance
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public Zero()
        {
            Type = "Zero";
        }
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery charging...");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeeeeoooooooooowwww!");
        }
        public override void Turn()
        {
            Console.WriteLine("The vehicle carefully turns right.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop.");
        }
    }
}