namespace stringReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
