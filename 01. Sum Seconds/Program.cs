using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //int racer1 = int.Parse(Console.ReadLine());
            //int racer2 = int.Parse(Console.ReadLine());
            //int racer3 = int.Parse(Console.ReadLine());

            //int totalTime = racer1 + racer2 + racer3;
            //int minutes = totalTime / 60;
            //int seconds = totalTime % 60;

            //if (seconds < 10)
            //{
            //    Console.WriteLine($"{minutes}:0{seconds}");
            //}
            //else
            //{
            //    Console.WriteLine($"{minutes}:{seconds}");
            //}


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
