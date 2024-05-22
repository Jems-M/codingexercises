namespace sumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumDigits(23182));
        }

        static int sumDigits(int n)
        {
            char[] chars = n.ToString().ToCharArray();
            List<int> digits = new List<int>();

            foreach (char c in chars)
            {
                string cStr = c.ToString();
                digits.Add(int.Parse(cStr));
            }

            return digits.Sum();
        }
    }
}
