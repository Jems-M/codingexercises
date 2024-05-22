namespace twoSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10));
        }

        static Tuple<int, int> findTwoSum(List<int> nums, int target)
        {

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = 0;  j < nums.Count; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }

            }

            return null;

        }
    }
}
