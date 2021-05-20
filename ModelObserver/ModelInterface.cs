using System;
using System.Collections.Generic;
using System.Text;

namespace ModelObserver
{
    public interface ISubject
    {
        public void registerObserver(IObserver o);
        public void removeObserver(IObserver o);
        public void notifyObserver(); //通知
    }

    public interface IObserver
    {
        public void update(float temp, float humidity, float pressure);
    }

    public interface IDisplayElement
    {
        public void display();
    }
}
