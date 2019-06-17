namespace inheritance
{
    public interface IGasVehicle
    {
        string Type { get; }
        double FuelCapacity { get; }

        void RefuelTank();
    }
}