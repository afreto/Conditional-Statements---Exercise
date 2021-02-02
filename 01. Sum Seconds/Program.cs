using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTime = 0;
            totalTime += int.Parse(Console.ReadLine());
            totalTime += int.Parse(Console.ReadLine());
            totalTime += int.Parse(Console.ReadLine());

            int minute = 0;
            int seconds = 0;

            if (totalTime >= 120)
            {
                minute = 2;
                seconds = totalTime - 120;
            }
            else if (totalTime >= 60)
            {
                minute = 1;
                seconds = totalTime - 60;
            }
            else
            {
                seconds = totalTime;
            }
            Console.WriteLine($"{minute}:{seconds:d2}");

        }
    }
}
