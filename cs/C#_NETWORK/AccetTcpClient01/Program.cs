using System;
using System.Net;
using System.Net.Sockets;

namespace AccetTcpClient01
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("192.168.0.9"), 7);
            tcpListener.Start();
            Console.WriteLine("대기상태시작");
            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            Console.WriteLine("대기상태종료");
            tcpListener.Stop();
        }
    }
}
