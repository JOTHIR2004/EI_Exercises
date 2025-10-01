using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Utils
{
    public static class Validator
    {
        public static int ValidateInt(string input)
        {
            if (int.TryParse(input, out int result))
                return result;
            throw new ArgumentException("Invalid integer input.");
        }

        public static bool ValidateTimeFormat(string input)
        {
            return TimeSpan.TryParse(input, out _);
        }
    }

}
