using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_class
{
    //연습 클래스 생성
    //클래스 == 설계도 == 데이터타입
    class Person    //설계도라고 정의 : 최소 : 속성(고유,상태,부품) + 기능 : 너 설계도 부르고 ...객체를 생성
    {   //속성(정보를 담는 그릇 : 크기 + 이름 > 변수)
        int num; //클래스가 가지는 변수 : instance variable(지역변수) : 생성되는 객체마다 가지는 변수
                 // Pserson p = new Person();   Person p2 = new Person();
                 //p.num과 p2.num 다른것
                 //기본적인 접근자를 가지고 있다
                 //아무것도 명시하지 않으면 private int num 으로 처리
                 //Tip) default int num JAVA는

        //private 데이터를 보호하겠다 의지가 ... 설계도를 만든 사람의 ...
        //객체지향 언어의 특징
        //캡슐화, 은닉화 자원을 보호 구현하는 기술 : private
        //1. private : 클래스 내부에서는 모두 같은 식구, 객체입장에서 볼수없음
        //2. public : 클래스 내부에서는 모두 같은 식구, 객체입장에서 볼수잇음 보호분제(직접할당)
        //3. private 사용하면서 객체가 사용할 수 있게
        //3.1 함수생성 : public : 캡슐화된 자원에 read, write ... (간접할당)

        private int k;
        public int y;

        private string ename;
        public int getK() //보호된 자원의 값을 return 읽기전용
        {
            return k;
        }
        public void setK(int data) //보호된 자원값을 쓰기전용
        {                          //설계자의 의도는 마이너스 값은 받지 않겠다.
            if(data < 0)
            {
                k = 0;
            }
            else if(data > 0)
            {
                k = data;
            }
        }

        //property : private member field에 대해서 간접적인 데이터 처리 목적 : read, write
        //int num > property > get, set > read, write 구현

        //smart field 이름도 사용
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        //ename의 property

        public string Ename
        {
            get { return ename + "님"; }
            set { ename = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //2명의 사람을 만드세요
            Person p = new Person();
            Person p2 = new Person();
            //p.num = 100; p라는 변수가 직접적으로 num 변수에 접근을 막는다.
            p.y = 100; //직접할당
            p2.y = 200; //직접할당
            //y라는 변수 양수값만

            p.setK(-100);
            Console.WriteLine(p.getK());

            p.Num = 555; //set {num = value;} 동작
            Console.WriteLine("get{0}", p.Num);

            p.Ename = "김유신";
            Console.WriteLine("get ename : {0}", p.Ename);

            Apt apt = new Apt();
            Console.WriteLine("apt.name : {0}",apt.Aptname);
            Console.WriteLine("apt.color : {0}",apt.Aptcolor);

            Apt apt2 = new Apt("LG", "yellow");
            Console.WriteLine("apt2.name : {0}", apt2.Aptname);
            Console.WriteLine("apt2.color : {0}", apt2.Aptcolor);



            #region 정리

            /*
             1. 클래스 == 설계도 == 데이터 타입
             2. 클래스 가장 기본적인 구성요소 > 속성(정보):member Field + 기능(함수):method
             3. 클래스 요소 중에 : 속성(instance variable, member filed)
             3.1 pivate 접근자를 통해서 캡슐화
             3.2 객체 입장에서 read, write (직접할당 불가)
             3.3 별도의 함수를(public) 통해서 get, set 구현
             3.4 전용 (raed, write) > property
             3.5 member field property 구현함으로써 간접적인 데이터처리 가능

             */

            #endregion


        }
    }

    class Apt
    {
        private string aptname;
        private string aptcolor;

        //함수 이용
        //특수한 목적의 함수 (사용방법은 member field의 초기화)
        //설계 약속 : 함수의 이름 클래스 이름과 같이...
        public Apt() //원칙적으로 함수는 public void or public int or public string
        {            //생성자 함수 (constructor) >> 객체가 생성될때 호출되는 함수
                     //Apt apt =new Apt();
                     //member field가 먼저 memory 올라가고 생성자 함수가 실행된다.
            aptname = "삼성";
            aptcolor = "red";

        }
        public Apt(string aptname, string aptcolor) //생성자 함수 // overloading(함수의 이름은 같은데 parameter의 개수와 타입을 다르게)
        {
            this.aptname = aptname;
            this.aptcolor = aptcolor;
        }


        public string Aptname
        {
            get { return aptname; }
        }
        public string Aptcolor
        {
            get { return aptcolor; }
        }
    }
    //요구사항
    //아파트를 만들 때 특별한 요구사항이 없으면 이름과 색상은 기본설정을 한다. 그리고 필요시 강제로 이름, 색상을 넣을 수 있게 한다.
    //Apt apt = new Apt(); null, null
}
