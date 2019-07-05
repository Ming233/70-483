using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedTasks
{
    class Program
    {
        public static int counter;

        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool right here..");
            });

            Console.WriteLine("Press any key to exist");
            Console.ReadLine();
        }
    }
}
