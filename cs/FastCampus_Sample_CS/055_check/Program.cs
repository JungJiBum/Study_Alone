using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_check
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i =1; i<=5; i++)
            {
                Random rnd = new Random();
                int first = rnd.Next(0, 100);
                int second = rnd.Next(0, 100);
                int total = first + second;
                int result;
                

                Console.WriteLine("{0} : 다음 두수의 합은 몇?(총 5문제)",i);
                Console.WriteLine("{0} + {1} = ?? ",first,second);
                result = int.Parse(Console.ReadLine());
                if(result == total)
                {
                    count++;
                    Console.WriteLine("==정답==");
                }
                else
                {
                    Console.WriteLine("오답(정답은 :{0})",total);
                }
            }
            Console.WriteLine("맞은 개수는 : {0}문제!", count);

        }
    }
}
