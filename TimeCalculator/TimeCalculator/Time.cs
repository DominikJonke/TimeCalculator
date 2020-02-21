using System;

namespace TimeCalculator
{
    public static class Time
    {
        public static int time = 0;
        public static int sec = 0;
        public static int min = 0;
        public static int hour = 0;

        public static void ShowTitle()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\tTime Calculator");
            Console.WriteLine();
        }
        public static void SetTime()
        {
            Console.Write("\tTime in seconds: ");
            time = Convert.ToInt32(Console.ReadLine());
        }
        public static void CalcTime()
        {
            sec = time % 60;
            min = time / 60;
            hour = time / 360;
        }
        public static void WriteTime()
        {
            Convert.ToString(sec);
            Convert.ToString(min);
            Convert.ToString(hour);
            Console.WriteLine($"\n\t\tTime: {hour:D2}:{min:D2}:{sec:D2}");
        }
    }
}