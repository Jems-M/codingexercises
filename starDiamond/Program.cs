using System.Text;

namespace starDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printStars(5);
        }

        static void printStars(int size)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= size; i++)
            {
                sb.Append(' ', size - i);
                sb.Append('*', i * 2 - 1);
                sb.Append("\n");
            }

            for (int i = size-1; i >= 1; i--)
            {
                sb.Append(' ', size - i);
                sb.Append('*', i * 2 - 1);
                sb.Append("\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
