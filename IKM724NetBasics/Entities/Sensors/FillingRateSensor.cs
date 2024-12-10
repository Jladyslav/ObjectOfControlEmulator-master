using IKM724NetBasics.Enums;
using System;

namespace IKM724NetBasics.Entities.Sensors
{
    public class FillingRateSensor : Sensor
    {
        public override SensorType Type => SensorType.FillingRate;

        public FillingRateSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = 15 + new Random().NextDouble() * (25 - 15); // Диапазон 15-25 кг/с
            Console.WriteLine($"{Name} Filling Rate: {Value:F2} kg/s");
        }
    }
}
