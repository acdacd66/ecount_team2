using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Basic { 

 class Car
{

}

    class Test
    {
        public int data;
    }

     class Program
    {
        static void Main(string[] args)
        {
            //onsole.WriteLine("Hellow world");
            char c;
            c = 'A';
            float f = 1.12f;
            double dd = 1.1234;

            int aa = 100;
            int bb = aa;
            bb = 200;
            Test t = new Test();
            Console.WriteLine(t.GetHashCode()); 

        }
    }
}
