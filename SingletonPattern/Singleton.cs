using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Singleton
    {
        private volatile static Singleton uniqueInstance;

        public static readonly object SingletonLocker = new object();

        private Singleton() { }

        public static Singleton getInstance()
        {
            if (uniqueInstance == null)
            {
                lock (SingletonLocker)
                {
                    if (uniqueInstance == null)
                        uniqueInstance = new Singleton();
                }
            }
            return uniqueInstance;
        }
    }
}
