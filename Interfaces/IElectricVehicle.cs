namespace inheritance
{
    public interface IElectricVehicle
    {
        string Type { get; }
        double BatteryKWh { get; }

        void ChargeBattery();
    }
}