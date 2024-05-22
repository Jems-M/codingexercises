namespace String1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(makeAbba("Hi", "Bye"));
        }

        static string helloName(string name) { return "Hello " + name + "!"; }

        static string makeAbba(string a, string b) { return a + b + b + a; }

        static string makeTags(string tag, string word) 
        { 
            return "<" + tag + ">" + word + "</" + tag + ">";
        }
    }
}
