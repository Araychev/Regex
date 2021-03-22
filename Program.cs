using System;
using System.Text.RegularExpressions;

namespace RegexlAB

{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            var regex = new Regex(patern);

            MatchCollection validNames = Regex.Matches(input, patern);

            foreach (Match item in validNames)
            {
                Console.Write($"{item.Value} ");
            }
            Console.WriteLine();
            
        }
    }
}
