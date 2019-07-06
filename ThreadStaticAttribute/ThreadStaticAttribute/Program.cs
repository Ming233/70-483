using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStaticAttribute
{
    public static class Program
    {
        public static int counter;

        public static void Main()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    counter++;
                    Console.WriteLine("Thread 1: {0}", counter);
                }
            } ).Start();

            new Thread(() =>
                 {
                for (int x = 0; x < 100; x++)
                {
                    counter++;
                    Console.WriteLine("Thread 2: {0}", counter);
                }
            } ).Start();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }
    }
}
