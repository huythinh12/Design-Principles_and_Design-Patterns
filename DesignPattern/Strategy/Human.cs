using System;

namespace DesignPattern.Strategy
{
    class Human : Character,IMovementStrategy
    {
     
        public string Move()
        {

            return "Movement type: Running";
        }
    }
}
