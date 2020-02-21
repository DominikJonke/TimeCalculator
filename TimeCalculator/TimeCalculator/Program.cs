using System;

namespace TimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Time.ShowTitle();

            Time.SetTime();

            Time.CalcTime();

            Time.WriteTime();

            Console.ReadKey();
        }
    }
}