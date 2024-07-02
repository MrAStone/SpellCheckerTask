namespace SpellCheckerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader words = new StreamReader("WordsFile.txt");
            Console.Write(words.ReadToEnd());
        }
    }
}
