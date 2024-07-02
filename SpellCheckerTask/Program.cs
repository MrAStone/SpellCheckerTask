namespace SpellCheckerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using  StreamReader words = new("WordsFile.txt");
            Console.Write(words.ReadToEnd());
        }
    }
}
