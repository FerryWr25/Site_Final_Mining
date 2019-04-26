using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site_Final_Mining.Model
{
    public class TimeCount
    {
        public string getTimeAgo(string strDate)
        {
            string strTime = string.Empty;
            if (IsDate(Convert.ToString(strDate)))
            {
                TimeSpan t = DateTime.Now - Convert.ToDateTime(strDate);
                double deltaSeconds = t.TotalSeconds;

                double deltaMinutes = deltaSeconds / 60.0f;
                int minutes;

                if (deltaSeconds < 5)
                {
                    return "Just now";
                }
                else if (deltaSeconds < 60)
                {
                    return Math.Floor(deltaSeconds) + " seconds ago";
                }
                else if (deltaSeconds < 120)
                {
                    return "A minute ago";
                }
                else if (deltaMinutes < 60)
                {
                    return Math.Floor(deltaMinutes) + " minutes ago";
                }
                else if (deltaMinutes < 120)
                {
                    return "An hour ago";
                }
                else if (deltaMinutes < (24 * 60))
                {
                    minutes = (int)Math.Floor(deltaMinutes / 60);
                    return minutes + " hours ago";
                }
                else if (deltaMinutes < (24 * 60 * 2))
                {
                    return "Yesterday";
                }
                else if (deltaMinutes < (24 * 60 * 7))
                {
                    minutes = (int)Math.Floor(deltaMinutes / (60 * 24));
                    return minutes + " days ago";
                }
                else if (deltaMinutes < (24 * 60 * 14))
                {
                    return "Last week";
                }
                else if (deltaMinutes < (24 * 60 * 31))
                {
                    minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 7));
                    return minutes + " weeks ago";
                }
                else if (deltaMinutes < (24 * 60 * 61))
                {
                    return "Last month";
                }
                else if (deltaMinutes < (24 * 60 * 365.25))
                {
                    minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 30));
                    return minutes + " months ago";
                }
                else if (deltaMinutes < (24 * 60 * 731))
                {
                    return "Last year";
                }

                minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 365));
                return minutes + " years ago";
            }
            else
            {
                return "";
            }
        }
        public static bool IsDate(string o)
        {
            DateTime tmp;
            return DateTime.TryParse(o, out tmp);
        }
        public string getCount(int day)
        {
            int hasilBLN = day / 30;
            int hasilDay = day % 30;
            string bulan = "";
            string hari = "";
            string return_data = "";
            if (hasilBLN > 0)
            {
                bulan = hasilBLN + "";
                hari = hasilDay + "";
                return_data = "Durasi kejadian " + bulan + " bulan " + hari + " hari";
            }
            else
            {
                hari = hasilDay + "";
                return_data = "Durasi kejadian " + hari + " hari";
            }
            return return_data;
        }
        public string runTime(string strDate1, string strDate2)
        {
            string hasil = "";
            DateTime date1 = Convert.ToDateTime(strDate1);
            DateTime date2 = Convert.ToDateTime(strDate2);
            TimeSpan timespan = date2.Subtract(date1);
            string count = timespan.TotalDays.ToString();
            return hasil = getCount(Convert.ToInt32(count));
        }
    }
}