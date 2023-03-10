using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SF2022UserLibrary;
using System.Threading.Tasks;

namespace SF2022ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan[] startTime = { new TimeSpan(10, 0,0), new TimeSpan(11, 0, 0), new TimeSpan(15, 0, 0), new TimeSpan(15, 30, 0), new TimeSpan(16, 50, 0) };
            int[] durations = {60,30,10,10,40};
            TimeSpan beginWorkingTime = new TimeSpan(08,0,0);
            TimeSpan endWorkingTime = new TimeSpan(18,0,0);
            int consultationTime = 30;

            string[] expected = { };
            Calculations obj = new Calculations();

            string[] actual = obj.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);

            for (int i = 0; i < actual.Length; i++)
            {
 Console.WriteLine(actual[i]);
            }
               
            
            Console.ReadKey();
        }
    }
}
