using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ModelObserver
{
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }


        public void notifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver ob = (IObserver)observers[i];
                ob.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if(i>=0)
            {
                observers.Remove(i);
            }
        }

        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float settemperature, float sethumidity, float setpressure)
        {
            temperature = settemperature;
            humidity = sethumidity;
            pressure = setpressure;
            measurementsChanged();
        }
    }
}
