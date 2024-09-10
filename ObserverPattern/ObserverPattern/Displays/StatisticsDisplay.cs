using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = float.MinValue;
        private float minTemp = float.MaxValue;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData) 
        { 
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Update de temperatuur en statistieken
            temperature = temp;
            sumTemperature += temp;
            countUpdated++;

            // Update maximale en minimale temperatuur
            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp) 
            { 
                minTemp = temp;
            }

            Display();
        }

        public void Display()
        {
            // Print the average, maximum and minimum temperature. Use appropriate fields
            float avgTemp = sumTemperature / countUpdated;

            Console.WriteLine($"Avg/Max/Min temperature = {avgTemp:F1}/{maxTemp:F1}/{minTemp:F1}°C");
        }
    }
}
