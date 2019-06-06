using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Midnight Blue",
                MaximumOccupancy = "4",
                BatteryKWh = 25.50
            };
            Zero fxs2 = new Zero()
            {
                MainColor = "Black",
                MaximumOccupancy = "4",
                BatteryKWh = 25.50
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Burgundy",
                MaximumOccupancy = "4",
                BatteryKWh = 44.00
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = "4",
                FuelCapacity = 89.50
            };
            Ram ram1500 = new Ram()
            {
                MainColor = "Silver",
                MaximumOccupancy = "4",
                FuelCapacity = 20.00
            };

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            fxs2.Drive();
            fxs2.Turn();
            fxs2.Stop();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            ram1500.Drive();
            ram1500.Turn();
            ram1500.Stop();
        }
    }
}
