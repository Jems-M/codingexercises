namespace nextPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(nextPrime(60));
        }

        static int nextPrime(int val)
        {
            val++;
            while (!isPrime(val))
            {
                val++;
            }

            return val;

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
