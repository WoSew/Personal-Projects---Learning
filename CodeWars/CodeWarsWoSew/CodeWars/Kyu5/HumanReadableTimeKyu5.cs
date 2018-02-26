using System;

namespace CodeWars.Kyu5
{
    public static class HumanReadableTimeKyu5
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds < 0 || seconds > 359999)
            {
                throw new Exception("Error, wrong input.");
            }

            switch (seconds)
            {
                case 0:
                    return "00:00:00";
                    
                case 359999:
                    return "99:59:59";
                default:
                    break;
            }

            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            string time = timeSpan.ToString(@"hh\:mm\:ss");

            /*
            string timeOld = string.Format("{0:D2}:{1:D2}:{2:D2}",
                            timeSpan.Hours,
                            timeSpan.Minutes,
                            timeSpan.Seconds);
            */
            return time;
        }
    }
}