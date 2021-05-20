using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ModelObserver
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;

        public CurrentConditionsDisplay(ISubject wData)
        {
            wData.registerObserver(this);
        }

        public void display()
        {
            WriteLine($"Current conditions: {temperature.ToString()} F degress and {humidity.ToString()} % humidity"); 
        }

        public void update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            display();
        }
    }
}
