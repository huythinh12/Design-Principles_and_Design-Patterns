using System;


namespace DesignPattern.Observer.BasicObserver
{
    public class ConcreteObserverA : IObserver
    {
        /// <summary>
        /// ở class ConcreteObserverB ta theo dõi statusName và statusNumber
        /// </summary>
        /// <param name="subject"></param>
        public void Update(ISubject subject)
        {
            var obj = (subject as Subject);
            Console.WriteLine("I'm ConcreteObserverA");
            Console.WriteLine($"StatusName is {obj.statusName}");
            Console.WriteLine($"StatusNumber is {obj.statusNumber}");

        }
    }
}
