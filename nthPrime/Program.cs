namespace nthPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getPrimeAtPosition(5));
        }
        static int getPrimeAtPosition(int position)
        {
            List<int> list = new List<int>();
            int i = 0;
            while (list.Count < position) {
                if (isPrime(i))
                {
                    list.Add(i);
                }
                i++;
            }
            return list.Last();
        }

        static Boolean isPrime(int x) 
        { 
            if (x <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
