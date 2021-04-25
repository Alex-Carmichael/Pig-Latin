using System;

namespace Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your word: ");
            string word = Console.ReadLine();

            word = word + "-" + word[0] + "ay";
            word = word.Substring(1);
            Console.Write(word);
            Console.ReadKey();
        }
    }
}
