﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_Operator_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;        //0000 0000     0000 0000       0000 0000       0000 1111
            int b = 22;        //0000 0000     0000 0000       0000 0000       0001 0110
            int c = a & b;   //0000 0000     0000 0000       0000 0000       0000 0110 =>6
            Console.WriteLine(" a & b : " + c);

                                    //0000 0000     0000 0000       0000 0000       0000 1111
                                    //0000 0000     0000 0000       0000 0000       0001 0110
            int d = a | b;     //0000 0000     0000 0000       0000 0000       0001 1111 => 31
            Console.WriteLine("a | b : " + d);

                                    //0000 0000     0000 0000       0000 0000       0000 1111
                                    //0000 0000     0000 0000       0000 0000       0001 0110
            int e = a ^ b;    //0000 0000     0000 0000       0000 0000       0001 1001 => 25
            Console.WriteLine("a ^ b : "+e);

                                        //0000 0000     0000 0000       0000 00000 0000 1111
            int f = a << 2;     //0000 0000     0000 0000       0000 00000 0011 11 00 => 60배 증가

            Console.WriteLine("a << 2 : " + f );
            Console.WriteLine("a << 1 : " + (a << 1)); // 왼쪽으로 1시프트 하면 2배로 증가(곱셈 연산 가능)


                                      //0000 0000     0000 0000       0000 00000 0001 0100 
            int g = 20 >> 2; //0000 0000     0000 0000       0000 00000 0000 0101 => 5
            Console.WriteLine("20 >> 2 : " + g);
            Console.WriteLine("(20 >> 1 ) : " + (20 >> 1)); //오른쪽으로 1시프트 하면 2로 나눔(나눗셈)


             //0000 0000        0000 0000       0000 0000       0001 0110
             //1111 1111        1111 1111       1111 1111       1110 1001 => -23
            int h = ~b;
            Console.WriteLine("h = ~b : " + h);

            //0000 0000        0000 0000       0000 0000       0001 0110
            //1111 1111         1111 1111       1111 1111       1110 1001 => -23
            //1111 1111         1111 1111       1111 1111       1111 1010 => -6 (CPU에 따라 다른 결과)
            int i = (~b) >> 2;
            Console.WriteLine("i = (~b) >> 2: " + i);
            
            //비트로 출력하기
            string s = Convert.ToString(a, 2).PadLeft(32, 'o');
            Console.WriteLine("s: " + s);
            s = Convert.ToString(b, 2).PadLeft(32, 'o');
            Console.WriteLine("s: " + s);


        }
    }
}
