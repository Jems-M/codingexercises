using System.Globalization;

namespace starPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printStars(6);
        }

        static void printStars(int height)
        {
            for (int i = 1; i < height; i++)
            {
                for (int j = 1; j <= height-i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
        }
    }
}
