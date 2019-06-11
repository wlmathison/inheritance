using System;

namespace inheritance
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public Tesla()
        {
            Type = "Tesla";
        }
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery charging...");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla zooms by you. Zzzzooooooommmmmmm!");
        }
        public override void Turn()
        {
            Console.WriteLine("The vehicle squeals around a left turn.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle quietly stops as if it had never moved.");
        }
    }
}