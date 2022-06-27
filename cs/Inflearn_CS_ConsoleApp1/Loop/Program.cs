using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            for(i = 0; i<6; i++)
            {
                for(j=0; j<6; j++)
                {
                    Console.WriteLine(i + "|" + j);
                }
            }


            //while (i < 6) // i가 6미만까지 반복
            //{
            //    Console.WriteLine("i = " + i);
            //    i++;
            //}
            //Console.WriteLine("WHILE i의 값은 : " + i);

            //for (j =0; j<6; j++)
            //{
            //    Console.WriteLine("j = " + j);
            //}
            //Console.WriteLine("FOR j의 값은 : " + j);

            //string[] strs = { "apple", "banana", "carrot", "durian" };

            //foreach(string k in strs)
            //{
            //    Console.WriteLine("k의 값은 " + k);
            //}

            //for(int l=0; l < strs.Length; l++)
            //{
            //    Console.WriteLine(strs[l]);
            //}
        }
    }
}
