namespace array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(centeredAverage([2, 3, 5, 8, 8, 12, 11, 24]));
        }

        static int countEvens(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        static int bigDiff(int[] nums)
        {
            return nums.Max() - nums.Min();
        }

        static int centeredAverage(int[] nums)
        {
            Array.Sort(nums);
            int total = 0;
            for (int i = 1; i < nums.Length - 1; i++) 
            {
                total += nums[i];
            }

            return total / (nums.Length - 2);
        }
    }
}
