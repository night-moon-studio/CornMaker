using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var interval = IntervalMaker.Create();
            interval.Hours(25);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("下一次运行任务的表达式："+interval.NextCorn());
            }
            Console.ReadKey();
        }
    }
}
