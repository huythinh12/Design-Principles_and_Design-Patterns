using DesignPattern.FactoryMethod.Animal;


namespace DesignPattern.FactoryMethod.FactoryAnimal
{
    //tạo các animal theo kiểu tuần hoàn
    class BasicAniamlFactory : IAnimalFactory
    {
        int index = 0;
        public IAnimal creatAnimal()
        {
            if (index == 0)
            {
                index++;
                return new Dog();
            }
            else if (index == 1)
            {
                index++;
                return new Cat();
            }
            else if (index == 2)
            {
                index = 0;
                return new Duck();
            }
            else
            {
                return null;
            }
        }
    }
}
