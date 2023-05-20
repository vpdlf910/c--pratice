See https://aka.ms/new-console-template for more information


using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static int Division(int a, int b)
        {
            return a / b;
        }
        static int Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
            return a;
            return b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("hello, World");
            Console.WriteLine("문자를 출력하기");
            int a;
            a = 100;
            float b;
            b = 100.13f;
            ushort c;
            c = 80;
            double d = 100.20003;
            Console.WriteLine(a);
            Console.Write(b);
            Console.WriteLine(c);
            Console.Write(d);

            char v = '문';
            string x = "자열을 저장";
            Console.WriteLine("{0}{1}", v, x);
            Console.WriteLine("{1}{0}", v, x);
            Console.WriteLine("{0}{1}", x, v);

            bool z = true;
            bool q = false;

            Console.WriteLine("{0},{1}", z, q);

            object w = "아무 문자열";
            object e = 50 * 2;
            object r = 12 * 3;
            object t = true;

            Console.WriteLine("{0}{1}{2}{3}", w, e, t, r);

            int ab = 12345678;
            double ba = 12.345678;

            Console.WriteLine("통화(C)....:{0:C}", ab);
            Console.WriteLine("10진법 (D){0:D}", ab);
            Console.WriteLine("지수 표기법 (E) {0:E}", ba);
            Console.WriteLine("고정 소수점 (F)..{0:F}", ba);
            Console.WriteLine("일반 (G)..{0:G}", ab);
            Console.WriteLine("숫자 (N)..{0:F}", ab);
            Console.WriteLine("16진법 (X)..{0:X}", ab);
            Console.WriteLine("백분율(P)..{0:P}", ba);

            a = 12;
            b = 1200.345678f;

            Console.WriteLine("0 자리 표시(0) :{0:00000}", a);
            Console.WriteLine("10진수 자리 표시(#) : {0:#.#}", a);
            Console.WriteLine("소수점 (.){0:0.00}{1:0.0}", b, a);
            Console.WriteLine("천 단위 자릿수 표시(,) {0:0,0}", a);
            Console.WriteLine("백분율 자리 표시(%) {0:0%}", b);
            Console.WriteLine("지수 표기법 (e) {0:0.000e+0}", b);

            a = 12345;
            Console.WriteLine("|{0,15}|", a);
            Console.WriteLine("|{0,-15}|", a);
            Console.WriteLine("|{0,15:N0}|", a);
            Console.WriteLine("|{0,-200:N0}|", a);
            Console.WriteLine("{0,15:N}", a);
            Console.WriteLine("{0,-15:N}", a);
            Console.WriteLine("{0,-15:000000}", a);

            int inta = 500;
            float floatb = inta;

            Console.WriteLine("{0} = {1} ", inta, floatb);

            double doublec = 123.45;
            int intd = (int)doublec;

            Console.WriteLine("c ={0} , d = {1}", doublec, intd);

            a = 500;
            b = 60.44f;
            string cd = a.ToString();
            string dc = b.ToString();

            Console.WriteLine("{0},{1},{2},{3}", a, b, cd, dc);
            Console.WriteLine(cd + dc);

            string ef = "123";
            string fe = "123.456";
            int ga = int.Parse(ef);
            float h = float.Parse(fe);

            Console.WriteLine("{0},{1},{2},{3}", ef, fe, ga, h);
            Console.WriteLine(ga + h);

            int num1 = 10;
            Console.WriteLine(num1++);
            Console.WriteLine(num1--);

            int num2 = 2;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 & num2);
            Console.WriteLine(num1 % num2);

            if (a > b)
            {
                Console.WriteLine("{0}>{1}", a, b);
            }
            else if (a == b)
            {
                Console.WriteLine("두 수는 동일하다.");
            }
            else
            {

                Console.WriteLine("크지 않다");
            }
            switch (a % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
            }

            string day = "화";

            switch (day)
            {
                case "월":
                    Console.WriteLine("월요일입니다.");
                    break;
                case "화":
                    Console.WriteLine("화요일입니다.");
                    break;
                case "수":
                    Console.WriteLine("수요일입니다.");
                    break;
                case "목":
                    Console.WriteLine("목요일입니다.");
                    break;
                case "금":
                    Console.WriteLine("금요일입니다.");
                    break;
                case "토":
                    Console.WriteLine("토요일입니다.");
                    break;
                case "일":
                    Console.WriteLine("일요일입니다.");
                    break;
            }
            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine("num: {0}", num++);

            }
            Console.WriteLine(num);
            int num3 = 0;
            do
            {
                Console.Write("글을 쓰자 ", num3++);

            } while (num3 < 10);

            for (int num4 = 1; num4 <= 10; num4++)
                Console.WriteLine("num4:{0}", num4);

            int[] arr = { 5, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int i in arr)
                Console.WriteLine(i);

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 1) continue;
                Console.WriteLine("i : " + i);
            }
            int num5 = 0;

            while (num5 < 100)
            {
                if (num5 == 40) goto EXIT;
                Console.WriteLine("num: " + num5++);
                num++;

            }
EXIT:
            Console.WriteLine("와 이게 되네");

            Console.WriteLine("a b {0}{1}", a, b);
            Swap(a, c);



            Console.WriteLine("{0}", Division(40, 10));

            Console.WriteLine(Swap(40, 10));
            Console.WriteLine(Division(10, 2));

            int[] list = { 1, 2, 3, 4, 5, 6 };
            int[] list2 = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(list);
            Console.WriteLine(list2);
            Console.WriteLine(list[1]);
            int i = 0;
            while (i < list.Length)
            {
                Console.WriteLine("{0}", list[i]);
                i++;
            }
            int[] list3 = new int[6];

            for (int z = 0; z < list3.Length; z++)
            {
                Console.WriteLine(list3[z]);

            }
            int[] reading = new int[] { 4, 9, 1, 0, 21, 12 };

            Console.WriteLine("속성: Rank={0}, Length={1}", reading.Rank, reading.Length);

            Console.Write("Clear 메소드:");
            Array.Clear(reading, 0, 5);

            Array.ForEach<int>(reading, new Action<int>(ShowValue));

            Console.WriteLine();
            Console.Write("Resize 메소드:");
            Array.Resize(ref reading, reading.Length + 3);
            Array.ForEach<int>(reading, new Action<int>(ShowValue));
            Console.WriteLine();

            Console.WriteLine("indexOf 메소드: {0}", Array.IndexOf(reading, 12));

            int[,] reading2 = new int[3, 6] { { 4, 9, 1, 0, 21, 12 }, { 1, 2, 3, 4, 5, 6, }, { 4, 4, 2, 4, 0, 0 } };

            for (int x = 0; x < reading2.GetLength(0); x++)
            {

                for (int j = 0; j < reading2.GetLength(1); j++)
                    Console.WriteLine("reading2 {0}", reading2[x, j]);
            }

        }

        static void ShowValue(int value)
        {
            Console.WriteLine("{0}", value);
        }
    }
}


using System.ComponentModel.DataAnnotations;
using System.Net.Cache;
using System.Runtime.CompilerServices;

class A
{
    private int num;
    private int num2;

    public A(int num, int num2) => this.num = num;

    public void Show()
    {
        Console.WriteLine("num:" + num);
    }
}


namespace classpra
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(325, "BMW");

            car.ShowCarInformation();
            car.IncreaseSpeed(50);
            car.IncreaseSpeed(40);
            car.IncreaseSpeed(210);
            car.IncreaseSpeed(30);

            Foo foo1 = new Foo() { Name = "foo", Value = 3 };
            Foo foo2 = new Foo("foo") { Value = 3 };

            Foo foo3 = new Foo();
            foo3.Name = "foo";
            foo3.Value = 3;

            Foo foo4 = new Foo("foo");
            foo4.Value = 3;

            Person person = new Person()
            {
                Name = "홍길동",
                Age = 20,
                Address = new Address
                {
                    Street = "서울시 서초구 서초동",
                    City = "서울",
                    State = "서울특별시"
                }
            };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Address.City);
            Console.WriteLine(person.Address.State);
        }
    }
    class Person
    {
        public string Name;
        public int Age;
        public Address Address;
    }
    class Address
    {
        public string Street;
        public string City;
        public string State;
    }
    //class project {
    //    static void Main(string[] args)
    //    {
    //        A a = new A(500);

    //        a.Show();            
    //    }
    //}
    class Foo
    {
        private int data = 10;
        private double range = 5.5;
        private string name;

        public string Name;
        public int Value;

        public Foo() { }
        public Foo(string name)
        {
            Name = name;
        }
    }
    class Car
    {
        private int maxSpeed;
        private int speed;
        private string model;

        public Car(int maxSpeed, string model)
        {
            this.speed = 0;
            this.maxSpeed = maxSpeed;
            this.model = model;
        }
        public void ShowCarInformation()
        {
            Console.WriteLine(model + "의 현재 속도:" + speed + "km/h" + "최대 속도: " + maxSpeed + "km/h");

        }
        public void IncreaseSpeed(int increment)
        {
            if (speed + increment > maxSpeed)
                Console.WriteLine("최대속도" + maxSpeed + "km/h를 넘을 수 없습니다.");
            else
            {
                speed += increment;
                Console.WriteLine(model + "의 현재 속도는 " + speed + "km/h 입니다");

            }
        }
        public void DecreaseSpeed(int decrement)
        {
            if (speed - decrement < 0)
                Console.WriteLine("속도는 0 아래로 떨어질 수 없습니다.");
            else
            {
                speed -= decrement;
                Console.WriteLine(model + "의 현재 속도는 " + speed + "km/h 입니다.");
            }
        }
    }
}

using System.Runtime.CompilerServices;

namespace ConsoleApplication8
{
    class Parent
    {
        public int num;

        public virtual void A()
        {
            Console.WriteLine("부모 클래스의 A() 메서드 호출!");
        }
        public Parent()
        {
            Console.WriteLine("부모 클래스의 생성자가 호출되었습니다.");
        }
    }
    class Child : Parent
    {
        public Child(int num)
        {
            this.num = num;
            Console.WriteLine("자식 클래스의 생성자가 호출되었습니다.");
        }

        public override void A()
        {
            Console.WriteLine("자식 클래스의 A() 메서드 호출!");
        }
        public void DisplyValue()
        {
            Console.WriteLine("num의 값은 {0}입니다.", num);
        }
        public class MyClass
        {
            private string name = "John";

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (value.Length < 5)
                        name = value;
                }
            }
        }
        class Daughter : Parent
        {
            public override void A()
            {
                Console.WriteLine("자식 클래스 도터의 A()메서드 호출");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {

                Child cd = new Child(20);
                cd.DisplyValue();
                MyClass mc = new MyClass();
                Console.WriteLine(mc.Name);
                mc.Name = "breeee";

                Console.WriteLine(mc.Name);

                Parent parent = new Parent();
                parent.A();

                Child child = new Child(10);
                child.A();

                Daughter daughter = new Daughter();
                daughter.A();



            }



        }
    }

}

namespace console1
{
    class Parent
    {
        public int x = 100;
        public void A()
        {
            Console.WriteLine("부모 클래스의 A() 메서드 호출");

        }

    }
    class Child : Parent
    {
        public new int x = 200;
        public new void A()
        {
            Console.WriteLine("자식 클래스의 A() 메서드 호출");
        }
    }
    class Animal { }

    class Dog : Animal { }



    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.A();
            Console.WriteLine("x :{0}", parent.x);

            Child child = new Child();
            child.A();
            Console.WriteLine("x : {0}", child.x);

            Dog dog = new Dog();
            Animal animal = dog;
            Dog sameDog = (Dog)animal;
        }
    }
}

using Extention;

namespace Extention
{
    public static class ExtensionMethod
    {
        public static int Multiplication(this int var, int a, int b)
        {
            int result = var;

            for (int i = 0; i < b; i++)
                result *= a;
            return result;
        }
    }
}

namespace Example
{

    partial class Nested
    {
        public void Test() { Console.WriteLine("Test()"); }
    }
    partial class Nested
    {
        public void Test2() { Console.WriteLine("Test2"); }
    }
    partial class Nested
    {
        public void Test3() { Console.WriteLine("Test3()"); }
    }
    public class OuterClass
    {
        private int b = 70;

        public class InnerClass
        {
            OuterClass instance;
            public InnerClass(OuterClass b_instance)
            {
                instance = b_instance;
            }

            public void AccessVariable(int num)
            {
                this.instance.b = num;
            }
            public void ShowVariable()
            {
                Console.WriteLine("a : {0}", this.instance.a);
            }


        }
    }
    struct Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nested nested = new Nested();
            nested.Test();
            nested.Test2();
            nested.Test3();

            OuterClass outer = new OuterClass();
            OuterClass.InnerClass inner = new OuterClass.InnerClass(outer);

            inner.ShowVariable();
            inner.AccessVariable(60);
            inner.ShowVariable();
        }
    }
}

namespace ConsoleApp
{
    interface FaceA
    {
        void print();
    }

    interface FaceB
    {
        void print();
    }
    class Myclass : FaceA, FaceB
    {
        static void Main(string[] args)
        {
            Myclass mc = new Myclass();

            FaceA imca = mc;
            imca.print();

            FaceB imcb = mc;
            imcb.print();
        }
        void FaceA.print()
        {
            Console.WriteLine("FaceAprint");
        }
        void FaceB.print()
        {
            Console.WriteLine("FaceBprint");
        }
    }
}
