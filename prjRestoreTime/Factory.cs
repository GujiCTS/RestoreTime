using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace prjRestoreTime
{
    class Factory
    {
        public string calculation(string tp, string current, string max)
        {
            int currentHP;
            int maxHP;
            int time;
            if (!string.IsNullOrWhiteSpace(current))
            {
                if (!Regex.IsMatch(current, @"^\d+$"))
                {
                    return "!當前體力值只能是正整數";
                }
                currentHP = Convert.ToInt32(current);
            }
            else
            {
                return "!請輸入當前體力值";
            }

            if (!string.IsNullOrWhiteSpace(max))
            {
                if (!Regex.IsMatch(max, @"^\d+$"))
                {
                    return "!最大體力值只能是正整數";
                }
                maxHP = Convert.ToInt32(max);
            }
            else
            {
                return "!請輸入最大體力值";
            }

            if (currentHP > maxHP)
            {
                currentHP = maxHP;
            }

            if (Regex.IsMatch(tp.Substring(0, 1), @"^\d+$"))
            {
                time = (maxHP - currentHP) * Convert.ToInt32(tp.Substring(0, 1));
            }
            else
            {
                return "!系統異常";
            }

            return $"{DateTime.Now.Add(new TimeSpan(0, time, 0)):yyyy/MM/dd tt hh:mm:ss}";
        }
    }
}
