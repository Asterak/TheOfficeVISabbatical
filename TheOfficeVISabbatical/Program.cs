using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TheOfficeVISabbatical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sabb("Can I have a sabbatical?", 5, 5)); //"Sabbatical! Boom!"
            Console.WriteLine(Sabb("Why are you shouting?", 7, 2)); //"Back to your desk, boy."
            Console.WriteLine(Sabb("What do you mean I cant learn to code??", 8, 9));//"Sabbatical! Boom!"
            Console.WriteLine(Sabb("Please calm down", 9, 1)); //"Back to your desk, boy."
        }

        public static string Sabb(string x, int val, int happ)
        {
            return (Regex.Matches(x.ToLower(), @"[sabbatical]").Count() + val + happ) > 22 ? "Sabbatical! Boom!" : "Back to your desk, boy.";
        }
    }
}
