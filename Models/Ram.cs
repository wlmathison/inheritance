using System;

public class Ram : Vehicle
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        Console.WriteLine("Refueling...");
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram monsters past you. Rrrruuuummmbbblleee!");
    }
    public override void Stop()
    {
        Console.WriteLine("The vehicle slams to a stop.");
    }
}