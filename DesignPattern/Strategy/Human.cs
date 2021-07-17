

namespace DesignPattern.Strategy
{
    // đây là ConcreteStrategies class
    class Human : IMovementStrategy
    {
     
        public string Move()
        {

            return "Movement type: Running";
        }
    }
}
