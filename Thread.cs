using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_Example
{
    class TreadClass
    {
        public void Test()
        {
            lock (this) //this refers to the current thread
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(i);
                    //Console.WriteLine(Thread.CurrentThread.Name);
                    Thread.Sleep(700);
                }
            }
        }
        //public void Test1()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Hello");
        //    }
        //}
    }
}
