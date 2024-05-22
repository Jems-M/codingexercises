namespace string2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(catDog("catdogcatdogdogcat"));
        }

        static string doubleChar(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output = output.Insert(output.Length, input[i].ToString());
                output = output.Insert(output.Length, input[i].ToString());
            }

            return output;
        }

        static int countHi(string input)
        {
            int hiCount = 0;
            for (int i = 0; i < input.Length; i++) 
            {
                if (input[i] == 'h' && input[i+1] == 'i')
                {
                    hiCount++;
                }
            }

            return hiCount;
        }

        static bool catDog(string input)
        {
            int catCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'c' && input[i + 1] == 'a' && input[i + 2] == 't')
                {
                    catCount++;
                }
            }

            int dogCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'd' && input[i + 1] == 'o' && input[i + 2] == 'g')
                {
                    dogCount++;
                }
            }

            return catCount == dogCount;
        }
    }
}
