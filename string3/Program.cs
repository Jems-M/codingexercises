namespace string3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(equalIsNot("This is notnot"));
        }


        static int countYZ(string input)
        {
            int YZCount = 0;
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == 'y' || input[i] == 'z')
                {
                    if (i == input.Length - 1)
                    {
                        YZCount++;
                        continue; // in case the last char is a y or z
                    }
                }
                if (input[i] == 'y' && !Char.IsLetter(input[i + 1]))
                {
                    YZCount++;
                }

                if (input[i] == 'z' && !Char.IsLetter(input[i + 1]))
                {
                    YZCount++;
                }
            }

            return YZCount;
        }

        static String withoutString(string original, string remove)
        {
            string output = "";

            for (int i = 0; i < original.Length; i++)
            {
                if (i <= original.Length - remove.Length && original.Substring(i, remove.Length) == remove)
                {
                    i += remove.Length - 1;
                } else
                {
                    output += original[i];
                }
            }

            return output;
        }

        static Boolean equalIsNot(string input)
        {
            int countIs = 0;
            int countNot = 0;
            for (int i = 0; i <= input.Length; i++)
            {
                if (i <= input.Length - 2 && input.Substring(i, 2) == "is")
                {
                    countIs++;
                }

                if (i <= input.Length - 3 && input.Substring(i, 3) == "not")
                {
                    countNot++;
                }
            }

            return countIs == countNot;
        }
    }
}
