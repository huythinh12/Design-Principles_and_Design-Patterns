using DesignPattern.FactoryMethod.Shape;


namespace DesignPattern.FactoryMethod.FactoryShape
{
    interface IShapeFactory
    {
       IShape CreatShape(string shape);
    }
}
