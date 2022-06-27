using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //단항연산자
            int a = 5;
            a++; //1 더해줌
            Console.WriteLine(-a);
            
            //이항 연산자
            int b = 3;
            int c = 0;
            c = a - b;
            Console.WriteLine(c);
            c = a + b;
            Console.WriteLine(c);
            */
            //int c = (5 > 3) ? 2 : 0;
            ////( ) 조건이 참일때 2 거짓일때 0 출력
            //Console.WriteLine(c);

            //int a = 5;
            //int b = 6;
            //b = a;
            //Console.WriteLine("b" + b);
            //string str = "b" + ":" + b;
            //Console.WriteLine(str);

            ////덧셈 연산자 +
            //int a = 5;
            //int b = 2;
            //int c = a + b;
            //Console.WriteLine(c);
            //Console.WriteLine(a+b);

            ////뺄셈 연산자 - 
            //int d = a - b;
            //Console.WriteLine(d);
            //Console.WriteLine(a-b);

            ////곱셈 연산자 *
            //int e = a * b;
            //Console.WriteLine(e);
            //Console.WriteLine(a*b);

            ////나누기 연산자 /
            //int f = a / b;
            //Console.WriteLine(f);
            //Console.WriteLine(a/b);

            ////나머지 연산자 %
            //int g = a % b;
            //Console.WriteLine(g);
            //Console.WriteLine(a%b);

            ////증감 연산자 ++ / --
            //int a = 5;
            //int b = 10;
            //Console.WriteLine("a는"+a+" ++이 앞에 있을때 :" + ++a);
            //Console.WriteLine("b는"+b+" ++이 뒤에 있을때 :" + b++);

            //복합 대입 연산자 +=, -=, *=, %=, /=,
            //int a = 5;
            //a += 3;
            //Console.WriteLine(a);

            //int a = 3;
            //int b = 4;
            //string c = (a > b) ? "참 " : "거짓";
            //Console.WriteLine(c);

            //비트 연산자는 2진수로 계산
            //int a = 1; //0001
            //int b = 5; //0101
            //int c = 0; //0000
            //Console.WriteLine(a & b);
            //Console.WriteLine(a | b);

            int a = 1;  //0001*2
            int b = 5;
            a = a << 1;
            Console.WriteLine(a); //2
            a = a >> 1;
            Console.WriteLine(a); //1




        }
    }
}
