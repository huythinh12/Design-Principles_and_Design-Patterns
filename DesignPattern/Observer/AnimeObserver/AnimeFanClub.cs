using System.Collections.Generic;

namespace DesignPattern.Observer.AnimeObserver
{
    public class AnimeMovie
    {
        public string name;
        public string comment;
        public bool isCompleted;
    }
    public class AnimeEvent
    {
        public string eventName;
        public string caption;
    }
    public class AnimeFanClub : IEventManager
    {
        public AnimeMovie animeMovie;
        public AnimeEvent animeEvent;
        private List<IEventListeners> users = new List<IEventListeners>();

        public AnimeFanClub()
        {
            animeMovie = new AnimeMovie();
            animeEvent = new AnimeEvent();
        }

        public void Attach(IEventListeners user)
        {
            users.Add(user);
        }

        public void Detach(IEventListeners user)
        {
            users.Remove(user);
        }

        public void Notify()
        {
            foreach (var user in users)
            {
                user.Update(this);
            }
        }

        public void PostsAnimeMovieToGroup(string name, string comment , bool isCompleted)
        {
            animeMovie.name = name;
            animeMovie.comment = comment;
            animeMovie.isCompleted = isCompleted;
        }

        public void PostsEventToGroup(string name, string caption)
        {
            animeEvent.eventName = name;
            animeEvent.caption = caption;
        }
    }
}
