using System;
namespace inheritance
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public Cessna()
        {
            Type = "Cessna";
        }
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Refueling...");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies by you. Wwwhhhhooooosssssshhh!");
        }
        public override void Turn()
        {
            Console.WriteLine("The plane rolls right.");
        }
        public override void Stop()
        {
            Console.WriteLine("The plane rolls down the runway for a mile and stops.");
        }
    }
}