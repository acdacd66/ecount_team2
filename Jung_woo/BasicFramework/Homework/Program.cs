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
            Boolean auto = true;
            int balance = 0;


            while (auto)
            {
                Console.WriteLine("************************************");
                Console.WriteLine("1. 가위 | 2. 바위 | 3. 보 | 4. 종료");
                Console.WriteLine("************************************");

                Console.WriteLine("선택");
                int input;
                input = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                int opponent = rnd.Next(1, 3);


                switch (input)
                {
                    case 1:
                        Console.WriteLine("가위를 내셨습니다.");
                        if (opponent == 2)
                        {
                            Console.WriteLine("상대가 바위를 내서 졌습니다.");
                        }
                        else if (opponent == 3)
                        {
                            Console.WriteLine("상대가 보를 내서 이겼습니다.");
                        }
                        break; //switch 탈출
                    case 2:
                        Console.WriteLine("바위를 내셨습니다.");
                        if (opponent == 3)
                        {
                            Console.WriteLine("상대가 보를 내서 졌습니다.");
                        }
                        else if (opponent == 1)
                        {
                            Console.WriteLine("상대가 가위를 내서 이겼습니다.");
                        }

                        break; //switch 탈출
                    case 3:
                        if (opponent == 1)
                        {
                            Console.WriteLine("상대가 가위를 내서 졌습니다.");
                        }
                        else if (opponent == 2)
                        {
                            Console.WriteLine("상대가 바위를 내서 이겼습니다.");
                        }

                        break; //switch 탈출
                    case 4:
                        Console.WriteLine("종료");
                        auto = false;  //논리를 이용해서 while(false) 탈출
                        break; //switch 탈출

                    default:
                        Console.WriteLine("올바른 메뉴를 선택하세요");
                        break;

                }
                if (input == opponent)
                {
                    Console.WriteLine("비기셨습니다.");

                }
            }

            /* int unit = 10000;
             int num = 0;
             int sw = 0;
             int money;
             money = int.Parse(Console.ReadLine());
             while (unit >= 1)
                 {


                 num = (int)(money / unit);
                 Console.WriteLine("unit:{0},num:{1}", unit, num);
                 money -= (unit * num);
                 if(sw == 0)
                 {
                     unit /= 2;
                     sw = 1;
                 }
                 else
                 {
                     unit /= 5;
                     sw = 0;
                 }


             }*/
        }
    }
}
