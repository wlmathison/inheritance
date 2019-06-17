using System;

namespace inheritance
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn()
        {
            Console.WriteLine("The vehicle turns right.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle comes to a stop.");
        }
    }
}