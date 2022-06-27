using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Data_enum
{
    class Program
    {
        enum DAY_OF_WEEK
        {
            //enum을 선언할 때 특성 값을 주지않았다.
            //enum을 선언하면 알아서 기본적으로 가장 최상위 값이 0이된다.
            SUN,    //1
            MON,    //2
            THE,    //3
            WED,    //4
            THU,    //5
            FRI,    //6
            SAT,    //7
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SUN, (int)DAY_OF_WEEK.SUN);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.MON, (int)DAY_OF_WEEK.MON);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.THE, (int)DAY_OF_WEEK.THE);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.WED, (int)DAY_OF_WEEK.WED);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.THU, (int)DAY_OF_WEEK.THU);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.FRI, (int)DAY_OF_WEEK.FRI);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SAT, (int)DAY_OF_WEEK.SAT);

        }
    }
}
