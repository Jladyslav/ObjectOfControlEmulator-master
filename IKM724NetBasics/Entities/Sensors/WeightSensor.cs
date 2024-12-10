using IKM724NetBasics.Enums;
using System;

namespace IKM724NetBasics.Entities.Sensors
{
    public class WeightSensor : Sensor
    {
        public override SensorType Type => SensorType.Weight;

        public WeightSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = 900 + new Random().NextDouble() * (2200 - 900); // Диапазон 900-2200 кг
            Console.WriteLine($"{Name} Weight: {Value:F2} kg");
        }
    }
}
