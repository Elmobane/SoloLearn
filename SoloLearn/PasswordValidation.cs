using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SoloLearn
{
    class PasswordValidation
    {
        public static string ValidatePassword(string input)
        {
            Dictionary<string, int> charCounter = new Dictionary<string, int>();
            charCounter.Add("numCount", 0);
            charCounter.Add("specCount", 0);

            string regNum = @"[0-9]";
            string regSpec = @"[!@$%&*]";
            Regex reNum = new Regex(regNum);
            Regex reSpec = new Regex(regSpec);
            foreach (var item in input)
            {
                if (reNum.IsMatch(item.ToString()))
                {
                    charCounter["numCount"]++;
                }
                if (reSpec.IsMatch(item.ToString()))
                {
                    charCounter["specCount"]++;
                }
            }

            if (charCounter["numCount"] > 1 && charCounter["specCount"] > 1 && input.Length > 1)
            {
                return "Strong";
            }
            else
            {
                return "Weak";
            }
        }
    }
}
