using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inflearn_CS_ConsoleApp1
{
    
    //주 시작점
    class Program
    {

        static void Main(string[] args)
        {
            //int num = -5;
            //int num2 = 5;
            //long bignum = 1000000000000000000L;
            //short smallnum = 5000;
            //byte smallnum2 = 250;
            //bool logic = true;
            //char chr = 'a';
            //string myname = "abc";
            //float num3 = 35.1F;
            //double num4 = 35.235D;

            //Console.WriteLine(num);
            //Console.WriteLine(num2);
            //Console.WriteLine(bignum);
            //Console.WriteLine(smallnum);
            //Console.WriteLine(smallnum2);
            //Console.WriteLine(logic);
            //Console.WriteLine(chr);
            //Console.WriteLine(myname);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            int a = 5;
            int b = 6;
            b = a;// b에 a값 저장
            //Console.WriteLine(b);

            string c = " ";
            //형변환을 통해 문자타입에 숫자를 저장하는 방법.
            c = a.ToString();

            Console.WriteLine("문자열 " + c);

            //string문자열 타입에 5 -> int num
            int num = Int32.Parse(c);
            //num에 숫자타입으로 변경해서 저장
            Console.WriteLine("정수형 " + num);
            

        }
    }
}
