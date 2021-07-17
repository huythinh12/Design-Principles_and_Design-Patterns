using System;


namespace DesignPattern.Observer.BasicObserver
{
    public class ConcreteObserverB:IObserver
    {
        /// <summary>
        /// ở class ConcreteObserverB ta chỉ cần theo dõi isStatusCheck
        /// </summary>
        /// <param name="subject"></param>

        public void Update(ISubject subject)
        {
            Console.WriteLine("I'm ConcreteObserverB");
            var obj = (subject as Subject);
            if(obj.isStatusCheck == true)
            {
                Console.WriteLine("Status is Checked");
            }
        }

    }
}
