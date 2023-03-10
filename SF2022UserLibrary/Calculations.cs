using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SF2022UserLibrary
{
    public class Calculations
    {

        public string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            if (beginWorkingTime > endWorkingTime) return Array.Empty<string>();

            List<TimeInterval> times = new List<TimeInterval>();
            List<string> availablePeriods = new List<string>();

            for (int i = 0; i < startTimes.Length; i++)
                times.Add(new TimeInterval(startTimes[i], durations[i]));

            for (TimeSpan time = beginWorkingTime; time.Add(new TimeSpan(0, consultationTime, 0)) <= endWorkingTime; time = time + new TimeSpan(0, 1, 0))
            {
                var tmp = new TimeInterval(time, consultationTime);

                if (times.All(x => x.isFalls(tmp)))
                {
                    availablePeriods.Add(tmp.ToString());
                    time = (tmp.EndTime - new TimeSpan(0, 1, 0));
                }
            }

            return availablePeriods.ToArray();
        }

        public static bool CheckingTheTime(string timeStarting)
        {

            if (String.IsNullOrWhiteSpace(timeStarting))
            {
                return false;
            }
          

                bool v = TimeSpan.TryParseExact(timeStarting, "hh\\:mm",null, out TimeSpan result);
                if (!v)
                {
                    return false;
                }
                return true;

            

           
        }

        public static bool CheckingDuration(string timeStarting)
        {
           

            if (String.IsNullOrWhiteSpace(timeStarting) == true)
            {
                return false;
            }
            if(timeStarting.Any(x=>Char.IsLetter(x)))
            {
                return false;
            }
            if (Convert.ToInt32(timeStarting) > 60 || Convert.ToInt32(timeStarting) < 0)
            {
                return false;
            }



            return true;
        }
    }
   
}


public struct TimeInterval
    {
        public TimeInterval(TimeSpan startTime, int durations)
        {
            StartTime = startTime;
            EndTime = StartTime + TimeSpan.FromMinutes(durations);
        }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public override string ToString() => StartTime.ToString(@"hh\:mm") + "-" + EndTime.ToString(@"hh\:mm");

        public bool isFalls(TimeInterval time) => StartTime >= time.EndTime || EndTime <= time.StartTime;
    }
   


    

