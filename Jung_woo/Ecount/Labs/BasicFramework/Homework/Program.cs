using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
     class Program
    {
        static void Main(string[] args)
        {
            //알파벳(A~Z) 까지 출력하는 프로그램을 작성하세요
            /*for (int i = 0; i < 26; i++)
            {
                Console.Write(Convert.ToChar(65+i));
            }
            Console.WriteLine();*/
            //1~100까지 10행 10열로 출력하는 프로그램을 작성하세요
            /* for (int i = 1; i <= 100; i++)
             {
                 if (i % 10 == 0)
                 {
                     Console.Write("\t {0} \n",i);

                     continue;

                 }
                 Console.Write("\t {0}", i);
             }

             Console.WriteLine();*/

            //두개의 주사위를 던졌을 때 눈의 합이 6이 되는 모든 경우의 수를 출력하는 프로그램을 작성하세요 
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if ((i + j) == 6)
                    {
                        Console.Write("첫번째 주사위:{0}, 두번째 주사위:{1}",i,j);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
