using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word = GetTheLastWord(new List<string> { "menna", "masa", "hazem", "montaser" });

            if(word == null)
                Console.WriteLine("The last word is null");
            else
            Console.WriteLine("The last word is {0}", word);
        }

        public static string GetTheLastWord(IEnumerable<string> words)
        {
            
            return
                    words
                    .Where(word => word.Contains('e'))
                    .OrderBy(str => str)
                    .LastOrDefault()
                    ;

        }
    }
}
