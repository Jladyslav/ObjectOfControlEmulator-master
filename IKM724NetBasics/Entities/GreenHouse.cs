using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities
{
    public class GreenHouse
    {
        public List<Sensor> Sensors { get; set; }
        public IrrigationSystem Irrigation { get; set; }
        public LightingSystem Lighting { get; set; }
        public VentilationSystem Ventilation { get; set; }

        public GreenHouse()
        {
            
            Sensors = new List<Sensor>
            {
                // Старые параметры
                new TemperatureSensor("Inner Temperature Sensor", "Measures the temperature inside the greenhouse"),
                new TemperatureSensor("Outer Temperature Sensor", "Measures the temperature outside the greenhouse"),
                
                // Новые параметры
                new WeightSensor("Weight Sensor", "Measures weight of material"),
                new FillingRateSensor("Filling Rate Sensor", "Measures the rate of filling"),
                new VoltageSensor("Voltage Sensor", "Monitors system voltage"),
                new MechanismTemperatureSensor("Mechanism Temperature Sensor", "Measures mechanism temperature"),
                new ConveyorSpeedSensor("Conveyor Speed Sensor", "Monitors conveyor belt speed")
            };

            // Инициализация систем управления
            Irrigation = new IrrigationSystem();
            Lighting = new LightingSystem();
            Ventilation = new VentilationSystem();
        }

        public void Monitor()
        {
            foreach (var sensor in Sensors)
            {
                sensor.ReadValue();
            }
        }
    }
}
