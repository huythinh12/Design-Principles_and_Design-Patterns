
namespace DesignPattern.Strategy
{
    // đây là ConcreteStrategies class
    public class Dragon : IMovementStrategy
    {
      
        public string Move()
        {
            return "Movement type: Flying";
        }
    }
}
