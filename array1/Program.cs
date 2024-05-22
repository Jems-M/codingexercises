namespace array1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(sameFirstLast([30, 12, 4, 30]));
        }

        static Boolean firstLast6(int[] array)
        {
            return array[0] == 6 || array[array.Length - 1] == 6;
        }

        static Boolean sameFirstLast(int[] array)
        {
            return array[0] == array[array.Length-1];
        }

        static int[] makePi() 
        { 
            return [3, 1, 4]; 
        }
    }
}
