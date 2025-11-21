using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;
using System.Text.RegularExpressions;

namespace OOP_Project
{
    public static class DateFormatter
    {
        public static string FormatAsYYYYMMDD(string input, int currentCursor, out int newCursor)
        {
            // Remove non-digits
            string digits = Regex.Replace(input, @"\D", "");

            if (digits.Length > 8)
                digits = digits.Substring(0, 8);

            string formatted = digits;

            if (digits.Length > 4 && digits.Length <= 6)
                formatted = digits.Substring(0, 4) + "-" + digits.Substring(4);
            else if (digits.Length > 6)
                formatted = digits.Substring(0, 4) + "-" + digits.Substring(4, 2) + "-" + digits.Substring(6);

            // Fix cursor position based on dash count
            int dashBefore = input.Take(currentCursor).Count(c => c == '-');
            int dashAfter = formatted.Take(currentCursor).Count(c => c == '-');

            newCursor = currentCursor + (dashAfter - dashBefore);

            return formatted;
        }
    }
}