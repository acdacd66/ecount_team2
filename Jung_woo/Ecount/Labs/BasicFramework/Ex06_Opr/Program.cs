using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Opr
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("100" + "100");
            Console.WriteLine("100" + 100);

            int i = 10;
            int j;
            j = i++;
            Console.WriteLine("i:{0}, j:{1}", i, j);
            j = ++i;
            Console.WriteLine("i:{0}, j:{1}", i, j);

            int k = 100;
            k++;
            ++k;

            int sum = 0;
            int s2 = 100;
            sum = sum + s2;

            sum += s2;

            int a = 10;
            int b = 20;
            if(a > 5 && b > 10)
            {
                Console.WriteLine("true");
            }

        }
    }
}
