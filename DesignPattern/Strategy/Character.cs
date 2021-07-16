using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public  class Character
    {
        private IMovementStrategy movementStrategy;
        public int Health { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }

     
       
        public Character()
        {

        }
        public Character(IMovementStrategy movementStrategy)
        {
            this.movementStrategy = movementStrategy;
        }
        public void SetMovementStrategy(IMovementStrategy value)
        {
            this.movementStrategy = value;
        }
        public void GetMovementType()
        {
            Console.WriteLine(this.movementStrategy.Move());  
        }
        public void DisplayInfo(string name, int health, int speed)
        {
            Name = name;
            Health = health;
            Speed = speed;
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Speed: " + Speed);
        }
    }
}
