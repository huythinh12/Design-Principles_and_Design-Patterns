using System;


namespace DesignPattern.Observer.AnimeObserver
{
    public class UserA : IEventListeners
    {

        public void Update(IEventManager eventManager)
        {
            Console.WriteLine("I'm UserA");

            AnimeFanClub animFanclub = (AnimeFanClub)eventManager;

            Console.WriteLine("Name :" + animFanclub.animeMovie.name);
            Console.WriteLine("Comment :" + animFanclub.animeMovie.comment);
            if (animFanclub.animeMovie.isCompleted == true)
            {
                Console.WriteLine("Status : Completed");
            }
            else
            {
                Console.WriteLine("Status : Waiting next chapter");
            }
        }
    }
}
