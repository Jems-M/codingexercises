namespace longestSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 3, 0, 0, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0  };

            Console.WriteLine(getLongestSequence(sequence));
        }

        static int getLongestSequence(int[] sales)
        {
            int currentStreak = 0;
            int longestStreak = 0;

            foreach (int day in sales)
            {
                if (day == 0)
                {
                    currentStreak++;
                } else
                {
                    currentStreak = 0;
                }
                if (currentStreak > longestStreak)
                {
                    longestStreak = currentStreak;
                }
            }

            return longestStreak;
        }
    }
}
