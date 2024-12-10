using IKM724NetBasics.Enums;
using System;

namespace IKM724NetBasics.Entities.Sensors
{
    public class VoltageSensor : Sensor
    {
        public override SensorType Type => SensorType.Voltage;

        public VoltageSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = 190 + new Random().NextDouble() * (230 - 190); // Диапазон 190-230 В
            Console.WriteLine($"{Name} Voltage: {Value:F2} V");
        }
    }
}
