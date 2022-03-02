using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_RefType
{

    class Test
    {
        public int i; 
        public void print()
        {
            int data = 100;
            Console.WriteLine("data:{0}",data);
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
           Test test = new Test();
            test.print();

            Test test2 = new Test(); 
            test2.print();

            Test test3 =  new Test();
            test3.print();

            for(int i = 0; i < 10; i++)
            {
                
            }
        }
    }
}
