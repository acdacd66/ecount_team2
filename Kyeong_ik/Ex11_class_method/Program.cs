using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_class_method
{
    //설계도 : 속성 + 기능

    //기능 == 행위 == method(함수)

    class Test
    {
        private int i; //instance variable, member field

        //행위 기능
        //method는 누군가 이름을 부르면 실행 (method call 되면 실행)
        //4가지
        //void, parameter(x)    : public void m(){실행코드}
        //void, parameter(o)    : public void m(int i){실행코드}
        //return, prameter(x)   : public int m(){ return 값 }
        //return, parameter(o)  : public int m(int i) {return i;}

        //parameter 인수, 인자, 매개값(변수)

        public void callMethod()
        {
            Console.WriteLine("일반함수");
        }
        public void callMethod2(int i)
        {
            if (i < 10)
            {
                Console.WriteLine("...");
            }
            else
            {
                Console.WriteLine("<<<<<<");
            }
        }

        public string callMethod3() // return type 함수의 결과 string 같은 타입을 전달
        {
            return "타입만 동일";
        }
        public string callMethod4(string str)
        {
            return str + "방가";
        }

        //추가적으로
        //return (o), parameter(o)
        public int callMethod5(int i, int j, int k)
        {
            return i + j + k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            //함수는 호출에 의해 실행
            test.callMethod();
            test.callMethod2(5);

            string result = test.callMethod3();
            Console.WriteLine(result);

            result = test.callMethod4("친구야");
            Console.WriteLine(result);

            int value = test.callMethod5(1, 2, 3);
            Console.WriteLine(value);
        }
    }
}
