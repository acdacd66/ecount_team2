using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_project
{
    class Class1
    {
        static void Main(string[] args)
        {
            Boolean auto = true;
            int balance = 0;
            int you = 0;
            int com = 0;
            int nowin = 0;

            while (auto)
            {
                
                string stryou = string.Empty;
                string strcom = string.Empty;
                Console.WriteLine("**************************************************");
                Console.WriteLine("1. 게임시작 | 2. 승률 | 3.승률초기화  | 4. 종료");
                Console.WriteLine("**************************************************");

                Console.WriteLine("선택");
                int input = 0;
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Random rnd = new Random();
                        int com1 = rnd.Next(1, 4);
                        Console.WriteLine("가위 : 1, 바위 : 2, 보 : 3");
                        int you1 = int.Parse(Console.ReadLine());
                        if (com1 == you1)
                        {
                            if (com1 ==1)
                            {
                                strcom = "가위";
                            }
                            else if (com1 == 2)
                            {
                                strcom = "바위";
                            }
                            else
                            {
                                strcom = "보";
                            }
                            Console.WriteLine("Computer : {0}", strcom);
                            Console.WriteLine("YOU : {0}", strcom);
                            Console.WriteLine("무승부 입니다.");
                            nowin++;
                        }
                        else
                        {
                            if (com1 == 1 && you1 == 2)
                            {
                                if (com1 == 1)
                                {
                                    strcom = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    strcom = "바위";
                                }
                                else
                                {
                                    strcom = "보";
                                }
                                if (you1 == 1)
                                {
                                    stryou = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    stryou = "바위";
                                }
                                else
                                {
                                    stryou = "보";
                                }
                                Console.WriteLine("Computer : {0}", strcom);
                                Console.WriteLine("YOU : {0}", stryou);
                                Console.WriteLine("당신은 승리자 입니다.");
                                you++;
                            }
                            else if (com1 == 1 && you1 == 3)
                            {
                                if (com1 == 1)
                                {
                                    strcom = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    strcom = "바위";
                                }
                                else
                                {
                                    strcom = "보";
                                }
                                if (you1 == 1)
                                {
                                    stryou = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    stryou = "바위";
                                }
                                else
                                {
                                    stryou = "보";
                                }
                                Console.WriteLine("Computer : {0}", strcom);
                                Console.WriteLine("YOU : {0}", stryou);
                                Console.WriteLine("당신은 패배자 입니다.");
                                com++;
                            }
                            else if (com1 == 2 && you1 ==3)
                            {
                                if (com1 == 1)
                                {
                                    strcom = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    strcom = "바위";
                                }
                                else
                                {
                                    strcom = "보";
                                }
                                if (you1 == 1)
                                {
                                    stryou = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    stryou = "바위";
                                }
                                else
                                {
                                    stryou = "보";
                                }
                                Console.WriteLine("Computer : {0}", strcom);
                                Console.WriteLine("YOU : {0}", stryou);
                                Console.WriteLine("당신은 승리자 입니다.");
                                you++;
                            }
                            else if (com1 == 2 && you1 == 1)
                            {
                                if (com1 == 1)
                                {
                                    strcom = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    strcom = "바위";
                                }
                                else
                                {
                                    strcom = "보";
                                }
                                if (you1 == 1)
                                {
                                    stryou = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    stryou = "바위";
                                }
                                else
                                {
                                    stryou = "보";
                                }
                                Console.WriteLine("Computer : {0}", strcom);
                                Console.WriteLine("YOU : {0}", stryou);
                                Console.WriteLine("당신은 패배자 입니다.");
                                com++;
                            }
                            else if (com1 == 3 && you1 == 1)
                            {
                                if (com1 == 1)
                                {
                                    strcom = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    strcom = "바위";
                                }
                                else
                                {
                                    strcom = "보";
                                }
                                if (you1 == 1)
                                {
                                    stryou = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    stryou = "바위";
                                }
                                else
                                {
                                    stryou = "보";
                                }
                                Console.WriteLine("Computer : {0}", strcom);
                                Console.WriteLine("YOU : {0}", stryou);
                                Console.WriteLine("당신은 승리자 입니다.");
                                you++;
                            }
                            else if (com1 == 3 && you1 == 2)
                            {
                                if (com1 == 1)
                                {
                                    strcom = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    strcom = "바위";
                                }
                                else
                                {
                                    strcom = "보";
                                }
                                if (you1 == 1)
                                {
                                    stryou = "가위";
                                }
                                else if (com1 == 2)
                                {
                                    stryou = "바위";
                                }
                                else
                                {
                                    stryou = "보";
                                }
                                Console.WriteLine("Computer : {0}", strcom);
                                Console.WriteLine("YOU : {0}", stryou);
                                Console.WriteLine("당신은 패배자 입니다.");
                                com++;
                            }
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("Com : {0}",com);
                        Console.WriteLine("YOU : {0}", you);
                        Console.WriteLine("무승부 : {0}", nowin);
                        break;
                    case 3:
                        com = 0;
                        you = 0;
                        nowin = 0;
                        Console.WriteLine("승률이 초기화 되었습니다.");
                        break;
                    case 4:
                        Console.WriteLine("게임이 종료되었습니다.");
                        auto = false;
                        break;
                    default:
                        Console.WriteLine("올바른 메뉴를 선택하세요");
                        break;

                }
            }
        }
    }
}
