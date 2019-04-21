using System;
using System.Threading;

namespace DockerTesterLinux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("response from DockerTester!!!");
            for (var i = 0; i < 100;i++)
            {
                Console.WriteLine($"index: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
