using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputVal = Console.ReadLine();
            string outputVal = Console.ReadLine();

            if (inputVal == "m" && outputVal == "cm")
            {
                number *= 100;
            }
            else if (inputVal == "cm" && outputVal == "m")
            {
                number /= 100;
            }
            else if (inputVal == "m" && outputVal == "mm")
            {
                number *= 1000;
            }
            else if (inputVal == "mm" && outputVal == "m")
            {
                number /= 1000;
            }
            else if (inputVal == "cm" && outputVal == "mm")
            {
                number *= 10;
            }
            else if (inputVal == "mm" && outputVal == "cm")
            {
                number /= 10;
            }

            Console.WriteLine($"{number:f3}");

        }
    }
}
