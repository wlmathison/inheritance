using System.Collections.Generic;

namespace inheritance
{
    public interface IStation<T>
    {
        int capacity { get; }
        void Refuel(List<T> vehicles);
    }
}