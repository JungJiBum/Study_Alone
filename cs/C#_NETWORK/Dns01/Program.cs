using System;
using System.Net;

namespace Dns01
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress[] IP = Dns.GetHostAddresses("www.naver.com");
            Console.WriteLine("네이버 아이피1 번{0}", IP);
            Console.WriteLine("네이버 아이피 2번 {1}", IP);
            Console.WriteLine();
            foreach (IPAddress HostIP in IP)
            {
                Console.WriteLine("{0}", HostIP);
            }

        }
    }
}
