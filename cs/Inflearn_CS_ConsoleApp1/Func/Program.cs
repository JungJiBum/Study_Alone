using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            Class1 class1 = new Class1();
            int c = class1.addNumber(a, b); //리턴값이 있는 int형 함수

            Console.WriteLine(c); 
            class1.soundFunction(); //리턴이 없는 함수
            class1.readNumber(10); //매개변수가 있는 함수
        }
    }
}
