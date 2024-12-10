using IKM724NetBasics.Enums;
using System;

namespace IKM724NetBasics.Entities.Sensors
{
    public class MechanismTemperatureSensor : Sensor
    {
        public override SensorType Type => SensorType.MechanismTemperature;

        public MechanismTemperatureSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = 45 + new Random().NextDouble() * (85 - 45); // Диапазон 45-85 °C
            Console.WriteLine($"{Name} Mechanism Temperature: {Value:F2} °C");
        }
    }
}
