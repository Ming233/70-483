using System;
using System.Threading;

namespace Treading
{
    class Program
    {
        public static void ThreadMethod()
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine("Theread Process{0}", i);
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();

            Console.ReadLine();
        }
    }
}
