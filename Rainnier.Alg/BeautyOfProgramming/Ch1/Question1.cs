using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rainnier.Alg.BeautyOfProgramming.Ch1
{
    class Question1
    {
        [DllImport("kernel32")]
        static extern int GetCurrentThreadId();
        static void RunThreadOnSpecificCPUCore()
        {
            Thread t = new Thread(
            new ThreadStart(DoWork)

            );
            t.Start();
        }
        static void DoWork()
        {
            foreach (ProcessThread pt in Process.GetCurrentProcess().Threads)
            {
                int utid = GetCurrentThreadId();
                if (utid == pt.Id)
                {
                    pt.ProcessorAffinity = (IntPtr)(1); // Set affinity for this thread to CPU #1
                    Console.WriteLine("Set");
                }
            }
            SinCPU();
        }

        public static void NearFullLoadCPU()
        {
            List<Thread> list = new List<Thread>();
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                list.Add(new Thread(CPU100));

            }

            foreach (var item in list)
            {
                item.Start();
            }
            
        }

        private static void CPU100()
        {
            while (true)
            {
                Task.Delay(100);
            }
        }

        public static void ConsumeCPU(int percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentException("percentage");
            
            List<Thread> list = new List<Thread>();
            for (int i = 0; i < 4; i++)
            {
                list.Add(new Thread(CPU));

            }

            foreach(var item in list)
            {
                item.Start(percentage);
            }

        }

        private static void CPU(object pcg)
        {
            int percentage = (int)pcg;
            Stopwatch watch = new Stopwatch();

            watch.Start();
            while (true)
            {
                // Make the loop go on for "percentage" milliseconds then sleep the 
                // remaining percentage milliseconds. So 40% utilization means work 40ms and sleep 60ms
                if (watch.ElapsedMilliseconds > percentage)
                {
                    Thread.Sleep(100 - percentage);
                    watch.Reset();
                    watch.Start();
                }

            }
        }

        public static void SinConsumeCPU()
        {
            List<Thread> list = new List<Thread>();
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                list.Add(new Thread(SinCPU));

            }

            foreach (var item in list)
            {
                item.Start();
            }
        }

        private static void SinCPU()
        {
            Stopwatch watch = new Stopwatch();

            const double CST = 30D;
            const double PI = 3.1415926D;
            double percentage;
            watch.Start();
            while (true)
            {
                //这段还可以，自己想的
                percentage = 50 + Math.Sin(DateTime.Now.Second / CST * PI) * 50;

                if (watch.ElapsedMilliseconds > percentage)
                {
                    Thread.Sleep(100 - (int)percentage);
                    watch.Reset();
                    watch.Start();
                }

            }
        }

    }
}
