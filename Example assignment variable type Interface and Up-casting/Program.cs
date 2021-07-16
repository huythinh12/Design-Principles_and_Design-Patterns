using System;


namespace Example_assignment_variable_type_Interface_and_Up_casting
{
    public interface I
    {
        void GetAge();
    }
    public interface Z
    {
        void GetWidth();
    }
    public class A : I, Z
    {
        public virtual void GetAge()
        {
            Console.WriteLine("I'm - A - 10 year old");
        }

        public virtual void GetWidth()
        {
            Console.WriteLine("I'm - A - 16.5 cm");

        }

        public virtual void Say()
        {
            Console.WriteLine("I'm - A");
        }

    }
    public class B : A
    {
        public override void Say()
        {
            Console.WriteLine("I'm - B");
        }
        public override void GetWidth()
        {
            Console.WriteLine("I'm - B - 18.5 cm");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //up-casting
            A a = new B();
            a.Say(); //=> I'm B

            // sử dụng type interface để khởi tạo variable và gán object cho variable đó
            // chỉ có thể thực hiện trên các object mà class của nó đã implement cái interface đó
            I i = new A();
            i.GetAge(); //=> I'm - A - 10 year old
            Z z = new A();
            z.GetWidth();//=> I'm - A - 16.5 cm

            // vì B là lớp con nên lớp con sẽ được kế thừa từ A là lớp cha nên ta không cần phải implement interface mà chỉ cần override lại thôi
            Z zz = new B();
            zz.GetWidth();//=> I'm - B - 18.5 cm

            // những class không implement interface đó sẽ không thể gán được vào variable type interface 
            Console.ReadKey();

        }
    }
}
