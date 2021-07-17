using System;

namespace DesignPattern.Strategy
{
    // Đây được gọi là Contex class
    public  class Character
    {
        private IMovementStrategy movementStrategy;
        public int Health { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }

        // constructor rỗng để chúng ta có thể lựa chọn việc khởi tạo rỗng
        public Character()
        {

        }

        // constructor có tham số để chúng ta có thể khởi tạo và truyền vào chiến lược cụ thể nào đó 
        public Character(IMovementStrategy movementStrategy)
        {
            this.movementStrategy = movementStrategy;
        }

        // tạo setter cho strategy để giúp chúng ta dễ dàng cài đặt và thay đổi trong runtime
        public void SetMovementStrategy(IMovementStrategy value)
        {
            this.movementStrategy = value;
        }

        // đây là method chính để xử lý cho các loại chiến lược khác nhau 
        // chúng ta có thể thấy rõ thay vì nó phải thực hiện mỗi loại chiến lược khác nhau thì ở đây chỉ cần thực hiện đúng 1 lần và nó sẽ phụ thuộc vào loại chiến lược hiện tại là gì thì sẽ thay đổi theo cái đó
        public void GetMovementType()
        {
            Console.WriteLine(this.movementStrategy.Move());  
        }

        // đây là các method xử lý logic khác bên trong Contex class
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
