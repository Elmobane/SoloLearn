using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello@$World19";
            string results = "";
            Console.WriteLine(input);
            //results = PigLatin.ToPigLatin(input);
            //results = DejaVu.ChechForDejaVu(input);
            results = PasswordValidation.ValidatePassword(input);
            Console.WriteLine(results);


        }
    }
}
