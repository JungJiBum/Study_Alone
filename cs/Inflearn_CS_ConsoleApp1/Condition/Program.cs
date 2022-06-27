using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 10;

            //if (a < 1)
            //{
            //    //if 조건이 참일 때
            //    Console.WriteLine("a는 1보다 크다");
            //}
            //else if (a < 3)
            //{
            //    Console.WriteLine("a는 3보다 크다");
            //}
            //else if(a < 7)
            //{
            //    Console.WriteLine("a는7보다작다");
            //}
            //else
            //{
            //    Console.WriteLine("a의 값은 :" + a);
            //}

            int week = 3;

            switch (week)
            {
                case 1:
                    Console.WriteLine("Mon");
                    break;
                case 2:
                    Console.WriteLine("Tue");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 4:
                    Console.WriteLine("Thu");
                    break;
                case 5:
                    Console.WriteLine("Fir");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;

            }

        }
    }
}
