using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Duration
    {
        private int hour; 
        private int minute;
        private int second;
        public Duration(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
             this.second = second;
        }
        public Duration(int second)
        {
            this.second = second;
        }
        public override string ToString()
        {
            string res = "";
            if(hour != 0 && minute != 0 && second != 0)
            {
                res = $"{hour} hours / {minute} minutes / {second} seconds";
            
            }
            else
            {
                hour = second / 3600;
                second = second % 3600;
                minute = second / 60;
                second = second % 60;
                if (hour != 0) res = $"{hour} hours";
                if (minute != 0)
                {
                    if (res.Length == 0) res = $"{minute} minutes";
                    else res += $" / {minute} minutes";
                }
                if (second != 0)
                {
                    if (res.Length == 0) res = $"{second} second";
                    else res += $" / {second} second";
                }

            }
            return res;
        }
    }
}
