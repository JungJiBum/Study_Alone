using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxScore = int.MinValue;
            int minScore = int.MaxValue;
            

            for (int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요 :");
                int score = int.Parse(Console.ReadLine());

                if (maxScore < score)
                {
                    maxScore = score;
                }
                if (minScore > score)
                {
                    minScore = score;
                }
            }

            Console.WriteLine("최대값 {0}     최소값 {1}", maxScore, minScore);
        }
    }
}
