using System;

using System.Threading;

namespace Thread_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadClass demo = new ThreadClass();
            //Thread class we have created a thread > t1.
            //ThreadStart is a delegate which hold method ref > that method will be exe by thread
            Thread t1 = new Thread(new ThreadStart(demo.Test));
            Thread t2 = new Thread(new ThreadStart(demo.Test));
            Thread t3 = new Thread(new ThreadStart(demo.Test));
            t1.Name = "First Thread";
            t2.Name = "Second Thread";
            t3.Name = "Third Thread";
            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.Lowest;
            //t3.Priority = ThreadPriority.Highest;
            t1.Start();
            t1.Join();//weit for exe t1 thread
            Console.WriteLine("=========================");
            t2.Start();
            t2.Join();//weit for exe t2 thread
            Console.WriteLine("=========================");
            t3.Start();

        }
    }
}

