using System;


namespace DesignPattern.FactoryMethod.Shape
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("draw Rectangle");
        }
    }
}
