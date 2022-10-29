using System;

namespace Task
{
    public class Program
    {
        public static void Main()
        {
            for (int i = 100; i < 200; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}