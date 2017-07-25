using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlPalindromeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the full path of the xml file and Press Enter");
            var path = Console.ReadLine();
            if (string.IsNullOrEmpty(path))
            {
                path = "PalindromeXmlFile.xml";
            }

            PalindromeReader reader = new PalindromeReader();
            var wordList = reader.CheckXmlforPalindrome(path);
            AddWordsToDatabase(wordList);
        }

        static void AddWordsToDatabase(Dictionary<string, bool> words)
        {
            var wordsList = new List<WordTable>();
            var model = new Model();
            var existingWords = model.Palindromes.ToList();
            foreach (var word in words)
            {
                if (!existingWords.Any(x => x.Word == word.Key))
                {
                    wordsList.Add(new WordTable
                    {
                        Word = word.Key,
                        IsPalindrome = word.Value,
                        DateTimeStamp = DateTime.Now
                    });
                }
                else
                {
                    Console.WriteLine("The word " + word.Key + " already exists in the database.");
                }
            }
            if (wordsList.Count > 0)
            {
                var result = model.Palindromes.AddRange(wordsList);
                model.SaveChanges();
            }
            else
            {
                Console.WriteLine("No words to save in the database.");
                Console.ReadLine();
            }


        }
    }
}