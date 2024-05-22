namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPalindrome("step on no pets"));

            Console.WriteLine(isPalindrome("racecar"));

            Console.WriteLine(isPalindrome("book"));
        }

        static Boolean isPalindrome(string s)
        {
            return s == reverseString(s);
        }

        static string reverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            string output = new string(array);
            return output;
        }
    }
}
