using System;

namespace DesignPattern.FactoryMethod.Shape
{
    class Circle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("draw Circle");
        }
    }
}
