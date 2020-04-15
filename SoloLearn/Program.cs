using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "adjaf";
            string results = "";
            Console.WriteLine(input);
            //results = PigLatin.ToPigLatin(input);
            results = DejaVu.ChechForDejaVu(input);
            Console.WriteLine(results);


        }
    }
}
