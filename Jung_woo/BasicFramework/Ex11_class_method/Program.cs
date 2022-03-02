using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_class_method
{
    class Test
    {
        private int i;

        //행위 기능
        //4가지
        public void callMethod()
        {
            Console.WriteLine("일반 함수");
        }
        
    }
     class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.callMethod();
            
          
        }
    }
}
