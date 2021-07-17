using System;


namespace DesignPattern.Observer.AnimeObserver
{
    public class UserB : IEventListeners
    {
 
        public void Update(IEventManager eventManager)
        {
            Console.WriteLine("I'm UserB");

            AnimeFanClub animFanclub = (AnimeFanClub)eventManager;
            Console.WriteLine("Name Event : " + animFanclub.animeEvent.eventName);
            Console.WriteLine("Caption :"+ animFanclub.animeEvent.caption);
        }
    }
}
