using System;
using System.Text.RegularExpressions;

namespace hrSaying_Hi
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(@"^[Hh][Ii] [^dD]", RegexOptions.Compiled);
            var numCases = Int32.Parse(Console.ReadLine());
            while (numCases-- > 0)
            {
                var str = Console.ReadLine();
                if (regex.IsMatch(str))
                    Console.WriteLine(str);
            }
        }
    }
}
