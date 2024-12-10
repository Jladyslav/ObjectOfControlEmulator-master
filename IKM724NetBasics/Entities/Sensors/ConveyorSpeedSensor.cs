using IKM724NetBasics.Enums;
using System;

namespace IKM724NetBasics.Entities.Sensors
{
    public class ConveyorSpeedSensor : Sensor
    {
        public override SensorType Type => SensorType.ConveyorSpeed;

        public ConveyorSpeedSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            // Генерация значений в диапазоне 2-10 м/с
            Value = 2 + new Random().NextDouble() * (10 - 2);

            // Просто выводим значение в консоль
            Console.WriteLine($"{Name} Conveyor Speed: {Value:F2} m/s");
        }
    }
}
