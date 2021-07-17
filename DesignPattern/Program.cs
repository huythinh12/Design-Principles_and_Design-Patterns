using System;
//FactoryMethod
using DesignPattern.FactoryMethod.FactoryAnimal;
using DesignPattern.FactoryMethod.Animal;
using DesignPattern.FactoryMethod.FactoryShape;
using DesignPattern.FactoryMethod.Shape;

//Strategy
using DesignPattern.Strategy;

//Observer
using DesignPattern.Observer.BasicObserver;
using DesignPattern.Observer.AnimeObserver;

namespace DesignPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethod();
            //Strategy();
            Observer();
            Console.ReadKey();
        }
        private static void Observer()
        {
            //Example1();

            Console.WriteLine("----------------------------Example 2----------------------------");

            AnimeFanClub animeFanclub = new AnimeFanClub();

            UserA userA = new UserA();
            animeFanclub.Attach(userA);
            animeFanclub.PostsAnimeMovieToGroup("AttackOnTitan", "so awesome", true);

            Console.WriteLine("----------------------------Create Something New ----------------------------");
            UserB userB = new UserB();
            animeFanclub.Attach(userB);
            animeFanclub.PostsAnimeMovieToGroup("OnePunch", "What is fun of your life", false);            
            animeFanclub.PostsEventToGroup("Limited Edition Figure Random", "Only one day");

            animeFanclub.Detach(userA);
            animeFanclub.Detach(userB);
            Console.WriteLine("----------------------------Create Something New ----------------------------");
            animeFanclub.PostsAnimeMovieToGroup("OnePiece", "this is never end??", false);
            animeFanclub.PostsEventToGroup("Be yourself Together", "Summer event");

        }

        private static void Example1()
        {
            Console.WriteLine("----------------------------Observer Pattern----------------------------");
            Console.WriteLine("----------------------------Example 1----------------------------");
            // Đầu tiên ta tạo 1 object từ Subject class tức là Publisher là class quản lý các thông tin sự kiện mà object khác cần theo dõi 
            var subject = new Subject();

            // Sau đó ta sẽ tạo các ConcreteObserver object tức là các object đang quan tâm tới Subject class 
            // nói dễ hiểu hơn thì Subject class đại diện cho một chủ đề mà ta đang quan tâm trong chủ đề đó sẻ chia thành nhiều phần nhỏ giống như một tờ báo có nhiều mục
            var observerA = new ConcreteObserverA();

            Console.WriteLine("------------------------------------------------------------------------");
            // sau khi tạo ra ta sẽ attach các ConcreteObserver object này vào trong Subject để Subject có thể thông báo đến các ConcreteObserver object khi nó có sự thay đổi nào đó
            subject.Attach(observerA);
            Console.WriteLine($"----------------------------Subject Attach A----------------------------");
            // ta sẽ gọi xử lý các logic code trong Subject class nếu có sự thay đổi nào mà ConcreteObserver object đó đang quan tâm nó nó có thể nhìn thấy được còn không quan tâm sẽ không hiển thị lên.
            subject.SomeBusinessLogicStatusName("Sunny");
            subject.SomeBusinessLogicStatusNumber(1);
            subject.SomeBusinessLogicStatusCheck(false);


            var observerB = new ConcreteObserverB();
            Console.WriteLine("--------------------------------------------------------------------------");
            subject.Attach(observerB);
            Console.WriteLine($"----------------------------Subject Attach B ----------------------------");
            subject.SomeBusinessLogicStatusName("Rainy");
            subject.SomeBusinessLogicStatusNumber(2);
            subject.SomeBusinessLogicStatusCheck(false);


            Console.WriteLine("------------------------------------------------------------------------");

            // Khi ta thấy không muốn object nào đó theo dõi hoặc là quan tâm đến các thông tin và sự kiện từ Subject nữa ta có thể gỡ bỏ object đó ra khỏi Subject để khi có thông báo sẽ không phải gửi đến object này nữa 
            subject.Detach(observerB);
            Console.WriteLine($"----------------------------Subject Detach B ----------------------------");
            // Khi gỡ ra khỏi đó thì nó cũng sẽ không cập nhật bất kì sự kiện nào từ Subject nữa
            subject.SomeBusinessLogicStatusName("Thunder");
            subject.SomeBusinessLogicStatusNumber(3);
            subject.SomeBusinessLogicStatusCheck(false);
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
