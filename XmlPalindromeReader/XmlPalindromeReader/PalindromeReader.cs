using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlPalindromeReader
{
    public class PalindromeReader
    {
        public Dictionary<string, bool> CheckXmlforPalindrome(string filePath)
        {
            var palindromes = new Dictionary<string, bool>();
            XmlDocument xmldoc = new XmlDocument();            
            int i = 0;
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            var xmlnode = xmldoc.GetElementsByTagName("palindrome");
            if (xmlnode.Count > 0)
            {
                for (i = 0; i <= xmlnode.Count - 1; i++)
                {
                    var word = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();

                    if (!palindromes.Any(x => x.Key == word))
                    {
                        palindromes.Add(word, IsPalindrome(word));
                    }
                    else
                    {
                        Console.WriteLine("Duplicate word found in the xml :" + word);
                    }
                }
            }
            else
            {
                Console.WriteLine("The xml file does not have any palindrome tag.");
            }

            return palindromes;
        }

        private bool IsPalindrome(string word)
        {
            string first = word.Substring(0, word.Length / 2);
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
            //return word.SequenceEqual(word.Reverse());
        }
    }
}
