using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface ISubject
    {
        void Add(IObserver observer);

        void Remove(IObserver observer);

        void Notify();

        string SomeData();
    }
}
