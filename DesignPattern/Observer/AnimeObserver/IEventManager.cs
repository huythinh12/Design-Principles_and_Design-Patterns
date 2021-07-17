
namespace DesignPattern.Observer.AnimeObserver
{
    public interface IEventManager
    {

        void Attach(IEventListeners user);
        void Detach(IEventListeners user);
        void Notify();
    }
}
