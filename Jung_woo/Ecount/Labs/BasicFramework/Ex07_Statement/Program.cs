using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Statement
{
     class Program
    {
        static void Main(string[] args)
        {
           
            
        /*    for(int i = 0; i < 10;i++)
            {
                Console.WriteLine("i :{0}",i);
            }

            for(int i = 2; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    if (i == j) break;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i == j) continue;
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            /*int result;
            Console.Write("숫자값을 입력하세요");
            result = int.Parse(Console.ReadLine());

            switch (result)
            {
                case 1: Console.WriteLine(result);
                    break;
                case 2:
                    Console.WriteLine(result);
                    break;
                case 3:
                    Console.WriteLine(result);
                    break;
                default: Console.WriteLine("nothing");
                    break;
            }*/
            int k = 1;
            int ksum = 0;
           while(k <= 100)
            {
                ksum += k;
                k++;
            }
           Console.WriteLine(ksum);

            int h = 1;
            int hsum = 0;
            while(h <= 100)
            {
                if((h&2) != 0)
                {
                    hsum += h;
                }
                h++;
            }
            Console.WriteLine(hsum);

         /*   string id, pw;
            Console.WriteLine("id");
            id = Console.ReadLine();
            Console.WriteLine("pw");
            pw = Console.ReadLine();

            if (id == "admin" && pw == "1234")
            {
                Console.WriteLine("성공");
            }
            else
            {
                Console.WriteLine("넌 누구냐?");
            }*/

            int p2 = 10;
            int k2= -10;
            int result2 = (p2 == k2) ? p2 : k2;
            Console.WriteLine(result2);

            int x1 = 3;
            int x2 = 5;

            Console.WriteLine("x1 & x2: "+(x1&x2));
            Console.WriteLine("x1 | x2: " + (x1 | x2));

        }


    }
}
