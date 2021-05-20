using System;

namespace ModelObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weather = new WeatherData(); //主题实现类
            CurrentConditionsDisplay Display = new CurrentConditionsDisplay(weather); //构造中进行了注册

            weather.setMeasurements(80, 65, 30.4f); //包含通知   通知所有观察者 -》 观察者update -》 观察者调用display
        }
    }
}
