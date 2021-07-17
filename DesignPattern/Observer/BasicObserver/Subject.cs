using System;
using System.Collections.Generic;


namespace DesignPattern.Observer.BasicObserver
{
    public class Subject : ISubject
    {
        public int statusNumber = 0;
        public string statusName = "";
        public bool isStatusCheck = false;

        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Subject: Detach an observer.");
            observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notify to observer.");
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogicStatusName(string name)
        {
            Console.WriteLine("I'm doing something important with StatusName ");
            statusName = name;
          
            Notify();
        }
        public void SomeBusinessLogicStatusNumber(int number)
        {
            Console.WriteLine("I'm doing something important with StatusNumber");
          
            statusNumber = number;
            Notify();
        }
        public void SomeBusinessLogicStatusCheck(bool isCheck)
        {
            Console.WriteLine("I'm doing something important with StatusCheck");

            isStatusCheck = isCheck;
            Notify();
        }
       

    }
}
