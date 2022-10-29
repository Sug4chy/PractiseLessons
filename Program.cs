using System;
namespace Task
{
    public class Program
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                if (i % c == 0)
                    Console.WriteLine(i);
            }
        }
    }
}