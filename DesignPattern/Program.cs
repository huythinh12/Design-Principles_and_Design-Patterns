using System;
//FactoryMethod
using DesignPattern.FactoryMethod.FactoryAnimal;
using DesignPattern.FactoryMethod.Animal;
using DesignPattern.FactoryMethod.FactoryShape;
using DesignPattern.FactoryMethod.Shape;
//Strategy
using DesignPattern.Strategy;

namespace DesignPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod();
            Strategy();
            Console.ReadKey();
        }
        private static void Strategy()
        {
            Console.WriteLine("----------------------------Strategy----------------------------");
            // Ta sẽ khởi tạo một object từ Context class tức là class dùng để giải quyết vấn đề chính
            // Sau đó ta sẽ truyền vào các ConcreteStrategies class tức là các class con được tạo ra nhằm để giải quyết các chiến lược khác nhau.
            Character character = new Character();
            Random random = new Random();
            int number = random.Next(0, 2);
            switch (number)
            {
                case 0:
                    character.SetMovementStrategy(new Human());
                    character.GetMovementType();
                    character.DisplayInfo("Soldier", 100, 50);
                    break;
                case 1 :
                    character.SetMovementStrategy(new Dragon());
                    character.GetMovementType();
                    character.DisplayInfo("BlackDragon", 1000, 160);
                    break;
                default:
                    break;
            }

        }
        private static void FactoryMethod()
        {
            Console.WriteLine("----------------------------FactoryMethod ----------------------------");
            Console.WriteLine("----------------------------Example 1----------------------------");
            // khởi tạo factory
            IAnimalFactory factory;

            // cho random loại factory
            // ở đây ta đã tạo ra 2 loại factory:
            // 1 - là factory tạo ngẫu nhiên animal 
            // 2 - là factory tạo tuần tự animal 
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                // đây là factory tuần tự
                factory = new BasicAniamlFactory();
            }
            else
            {
                //đây là factory ngẫu nhiên
                factory = new RandomAnimalFactory();
            }

            // Ở đây factory.create Animal sẽ trả về object animal
            // Sau đó ta sẽ gán object này cho animal
            // Việc gán Animal cho IAnimal variable này thực hiện được vì các class animal đều thực thi interface IAnimal này
            // Hiểu đơn giản thì nó đang có cùng kiểu dữ liệu hoặc có thể nói là cùng type
            IAnimal animal = factory.creatAnimal();
            Console.WriteLine(animal.getName());

            // Hoặc có thể làm theo cách này
            // Điều này có nghĩa là ta đã tạo ra object animal ngẫu nhiên và gọi method từ object đó
            Console.WriteLine(factory.creatAnimal().getName());
            Console.WriteLine(factory.creatAnimal().getName());
            Console.WriteLine(factory.creatAnimal().getName());
            Console.WriteLine(factory.creatAnimal().getName());
            Console.WriteLine(factory.creatAnimal().getName());
            Console.WriteLine(factory.creatAnimal().getName());

            Console.WriteLine("----------------------------Example 2----------------------------");

            IShapeFactory factoryShape;
            factoryShape = new BasicShapeFactory();
            IShape shape1 = factoryShape.CreatShape("Circle");
            shape1.Draw();
            IShape shape2 = factoryShape.CreatShape("Rectangle");
            shape2.Draw();
            IShape shape3 = factoryShape.CreatShape("Square");
            shape3.Draw();
        }
    }
}
