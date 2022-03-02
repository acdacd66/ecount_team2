using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Statement2
{
     class Program
    {
        static void Main(string[] args)
        {
            int data = 90;

            /*
                        switch (data)
                        {
                            case 100:
                                Console.WriteLine(data);

                            case 90:
                                Console.WriteLine(data);

                            case 80:
                                Console.WriteLine(data);

                            default:
                                Console.WriteLine("nothing");

                        }*/
            string final;
            int grade = int.Parse(Console.ReadLine()); 
            if (grade >= 90)
            {
                final = "A";
                final = (grade >= 95) ? (final += "+"): (final += "-");
             
            }
            else if (grade >= 80)
            {
                final = "B";
            }
            else if (grade >= 70)
            {
                final = "C";
            }
            else
            {
                final = "F";
            }

            Console.WriteLine(final);


            int month = 1;
            string res = ""; //빈 문자열로 초기화
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    res = "31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    res = "30";
                    break;
                case 2:
                    res = "29";
                    break;
                default:
                    res = "월 데이터가 아닙니다";
                    break;
            }
            Console.WriteLine(res);
        }
    }
}
