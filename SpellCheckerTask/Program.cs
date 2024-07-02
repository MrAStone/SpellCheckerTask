using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System;

namespace SpellCheckerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = createDictionary();
            //1. Take a user input of a word an check if it has been spelled correctly

            //2. Take a string of words as a user input and check they have all been spelled correctly

            //3.Create a spelling score based on the percentage of words spelled correctly

            //4.Create a new list of words that have been spelled incorrectly and save it in a new file

            //Challenge - Hard task

            //Try to work out which words the user is trying to spell by looking for similarities in
            //the spelling and ask the user did they mean that.

            //Add these suggested words to a spelling list that the user can save as a file to work on
            //their own spelling



        }
        static string[] createDictionary()
        {
            using StreamReader words = new("WordsFile.txt");
            int count = 0;
            string[] dictionaryData = new string[178636];
            while (!words.EndOfStream)
            {

                dictionaryData[count] = words.ReadLine();
                count++;
            }
            words.Close();
            return dictionaryData;
        }
    }
}
