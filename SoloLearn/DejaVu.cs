using System;
using System.Collections.Generic;
using System.Text;

namespace SoloLearn
{
    class DejaVu
    {
        public static string ChechForDejaVu(string input)
        {
            Dictionary<char, int> chaLib = new Dictionary<char, int>();

            foreach (char item in input)
            {
                if (chaLib.ContainsKey(item))
                {
                    chaLib[item]++;
                    if (chaLib[item] > 1)
                    {
                        return "Deja Vu";
                    }
                }
                else
                {
                    chaLib.Add(item, 1);
                }
            }
            return "Unique";
        }
    }
}
