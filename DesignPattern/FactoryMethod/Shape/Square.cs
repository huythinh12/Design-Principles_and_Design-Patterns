using System;


namespace DesignPattern.FactoryMethod.Shape
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("draw Square");
        }
    }
}
