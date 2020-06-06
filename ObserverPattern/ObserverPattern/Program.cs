using System;
using System.Linq.Expressions;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var subject = new Subject();
            var concreateObjectA = new ConcreteObserver();

            subject.Add(concreateObjectA);

            subject.SomeBusinessLogic();

            Console.ReadLine();
        }
    }
}
