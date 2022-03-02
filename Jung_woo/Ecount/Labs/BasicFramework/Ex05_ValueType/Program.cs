using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_ValueType
{
    #region +값 타입: 구조체
    struct Book
    {
        public string name;
        public int price;

        public Book(string _name, int _price)
        {
            name = _name;
            price = _price;
        }
    }

    enum mycolor { blakc, white, red, green, blue };
    enum week { mon, tue = 101, sat, sun };
    class Car
    {
        public string name;
        public int price;

        public Car(string _name, int _price)
        {
            name = _name;
            price = _price;
        }
    }

    struct Human
    {
        public string ename;
        public int age;
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            float f = 3.14f;

            Book book = new Book("홍길동전", 10000);

            Book book2 = book; // book의 값이 book2에 복사된다.

            book2.name = "New";
            book2.price = 30000;

            Car car = new Car("GV89", 29999);

            Human h;
            h.ename = "홍길동";
            h.age = 100;
            Console.WriteLine(h.ename);
            Console.WriteLine(h.age);

            mycolor m;
            m = mycolor.blakc;
            Console.WriteLine(m);
            Console.WriteLine((int)m);

            //시스템이 제공하는 열거타입
            Console.BackgroundColor = ConsoleColor.Magenta;

            week w;
            w = week.sat;
            Console.WriteLine("w:{0}",w);
            int a = 10;
            int b = 20;

            Console.WriteLine($"string example1 : {a} + {b} = {a + b}");

            const double PI = 3.14; // 상수의 이름은 관용적으로 대문자를 쓴다.

            int num = 1234;
            long lon = num;
            //long lon = (long)num;

            long lon2 = 100000;
            int num2 = (int)lon2; //값으로 보지 말고 가지고 있는 타입으로 봐야 한다.
            //다행이도 형변환 값이 int 범위라면 손실없이 값을 가질 수 있다.

            var name = "문자열";
            Console.WriteLine(name.GetType());

            int i2 = default;

        }
    }
}
