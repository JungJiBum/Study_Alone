using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ans;
            int count=0;
            int number = rnd.Next(0, 100);
            while (true)
            {
                Console.Write("0~99사이 어떤 숫자일까요?(단, 0은 나가기)");
                ans = int.Parse(Console.ReadLine());
                if(ans == 0)
                {
                    break;
                }
                if(ans > number)
                {
                    Console.WriteLine("입력한 수가 크다.");
                    count++;
                }
                else if(ans < number)
                {
                    Console.WriteLine("입력한 수가 작다.");
                    count++;
                }
                else
                {
                    Console.WriteLine("=== 정답 입니다. ===");
                    break;
                }
            }
            Console.WriteLine("총 {0}번 시도", count);
        }
    }
}
