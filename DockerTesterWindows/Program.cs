using System;
using System.Threading;

namespace DockerTesterWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Console output from the DockerTesterWindows app");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
