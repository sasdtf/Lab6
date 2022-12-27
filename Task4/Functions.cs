using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    public static class Functions
    {
        public static bool CheckNumber(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException((input), "Пустая исходная строка!");
            }
            if (Regex.IsMatch(input, @"^([1-9][0-9]*)+([\,\.]0+)*$"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
