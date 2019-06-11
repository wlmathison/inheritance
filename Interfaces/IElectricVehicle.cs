namespace inheritance
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; }

        void ChargeBattery();
    }
}