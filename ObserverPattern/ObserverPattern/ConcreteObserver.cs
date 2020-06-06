using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ConcreteObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine(subject.SomeData());
        }
    }
}
