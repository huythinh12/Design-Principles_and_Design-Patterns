using DesignPattern.FactoryMethod.Shape;

namespace DesignPattern.FactoryMethod.FactoryShape
{
    class BasicShapeFactory : IShapeFactory
    {
        public IShape CreatShape(string shape)
        {
            if(shape == "Circle")
            {
                return new Circle();
            }
            else if (shape=="Rectangle")
            {
                return new Rectangle();

            }
            else if(shape == "Square")
            {
                return new Square();
            }
            else
            {
                return null;
            }
        }
    }
}
