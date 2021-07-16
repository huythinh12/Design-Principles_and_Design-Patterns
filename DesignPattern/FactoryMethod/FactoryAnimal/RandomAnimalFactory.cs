using DesignPattern.FactoryMethod.Animal;
using System;


namespace DesignPattern.FactoryMethod.FactoryAnimal
{
    //tạo các animal theo kiểu ngẫu nhiên
    class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal creatAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 3);

            if (type == 0)
            {
                return new Dog();
            }
            else if (type == 1)
            {
                return new Cat();
            }
            else
            {
                return new Duck();
            }

        }
    }
}
