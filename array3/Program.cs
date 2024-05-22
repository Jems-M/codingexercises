namespace array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = fix45([5, 1, 4, 3, 5, 6, 2, 8, 3, 6, 6, 7, 4, 2]);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static int maxSpan(int[] nums)
        {
            int currentSpan = 0;
            int currentNum = nums[0];
            int largestSpan = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == currentNum)
                {
                    currentSpan += 1;

                    if (currentSpan > largestSpan)
                    {
                        largestSpan = currentSpan;
                    }

                } else
                {
                    currentNum = nums[i];
                    currentSpan = 1;
                }

                
            }

            return largestSpan;
        }

        static int[] fix34(int[] nums)
        {
            List<int> movedNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] == 4 && !movedNums.Contains(j))
                        {
                            int placeholder = nums[i + 1];
                            nums[i + 1] = 4;
                            nums[j] = placeholder;
                            movedNums.Add(i + 1);
                        }

                    }
                }
            }
            return nums;
        }

        static int[] fix45(int[] nums)
        {
            List<int> movedNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 4)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] == 5 && !movedNums.Contains(j))
                        {
                            int placeholder = nums[i + 1];
                            nums[i + 1] = 5;
                            nums[j] = placeholder;
                            movedNums.Add(i + 1);
                        }

                    }
                }
            }
            return nums;
        }
    }
}
