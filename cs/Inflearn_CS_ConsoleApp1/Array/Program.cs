using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            //1차원 배열
            int[] a = { 1, 2, 3, 4 };
            string[] vars = { "파인애플", "사과", "토마토", "바나나" };

            //Console.WriteLine(vars[2]);
            //Console.WriteLine(vars[vars.Length - 1]);

            //2차원 배열 -> 1차원 배열을 여러개 가질 수 있다. 3차원 배열 -> 2차원 배열을 여러개 가질 수 있다.
            int[,] abc = { { 1, 2, 3,5 }, { 4, 5, 6, 7 }, { 4, 5, 6, 7 } };
            Console.WriteLine(abc[0,0]); //1
            Console.WriteLine(abc[0,3]); //5
            Console.WriteLine(abc[1,0]); //4
            Console.WriteLine(abc[2,1]); //5

            //가별 배열
            int[][] ab = new int[3][];
            ab[0] = new int[4];
            ab[1] = new int[4];
            ab[2] = new int[3];
            ab[2][2] = 4;
            Console.WriteLine(ab[2][0]);
            

            



        }
    }
}
