using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {

            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double distanceInseconds = distance * seconds;
            double delay = Math.Floor(distance / 15) * 12.5;
            double finalTime = distanceInseconds + delay;
            double neededTime = finalTime - recordInSeconds;
            if (finalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {neededTime:f2} seconds slower.");
            }
        }
    }
}
