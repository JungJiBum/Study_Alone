using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Class1
    {
       public int addNumber(int a, int b)
        {
            int c = a + b;

            return c;
        }
        public void soundFunction()
        {
            Console.WriteLine("소리를 낸다");
        }
        public void readNumber(int a)
        {
            Console.WriteLine("숫자를 출력하는 함수 : " + a);
        }
    }
}
