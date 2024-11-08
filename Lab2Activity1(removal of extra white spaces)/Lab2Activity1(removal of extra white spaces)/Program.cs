using System;
using System.Text.RegularExpressions;
namespace RegExApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "        Hello                World ";
            string pattern = "\\s+"; // The "\s+" regular expression pattern matches one or more whitespace characters (spaces, tabs, or line breaks).
            string replacement = " "; // This is the string that will be used to replace the matched whitespace sequences in the input string.
            Regex rgx = new Regex(pattern); // It prepares the regular expression engine to search for and replace all occurrences of the specified pattern in the input string.
            string result = rgx.Replace(input, replacement);
            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
            Console.ReadKey();
        }
    }
}