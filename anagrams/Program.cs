using System.Diagnostics;
using System.IO;

namespace anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray" };


            List<string> anagrams = findAnagrams("star", words);
            foreach (object i in anagrams)
            {
                Console.WriteLine(i);
            }
        }

        static List<string> findAnagrams(string target, string[] words)
        {
            List<string> output = new List<string>();
            foreach (string i in  words)
            {
                char[] iArray = i.ToCharArray();
                char[] targetArray = target.ToCharArray();
                Array.Sort(iArray);
                Array.Sort(targetArray);

                if (string.Join("", iArray) == string.Join("", targetArray))
                {
                    output.Add(i);
                }
            }

            return output;
        }
    }
}
