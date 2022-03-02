using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_class
{

    class Person
    {
        int num;
        private int k;
        public int y;

        public int getK()
        {
            return k;
        }
        public void setK(int data)
        {
            if (data < 0)
            {
                k = 0;
            }
            else
            {
                k = data;
            }
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p2 = new Person();
            p.y = 100;//직접 할당
            p2.y = 200;

            p.y = -100;
            p.setK(-100);
            Console.WriteLine(p.getK());


        }
    }
}
