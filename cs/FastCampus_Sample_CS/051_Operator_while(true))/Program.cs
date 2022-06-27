using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_Operator_while_true__
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (true)
            {
                Console.WriteLine("while(true){0}",++num);
            }
        }
    }
}
