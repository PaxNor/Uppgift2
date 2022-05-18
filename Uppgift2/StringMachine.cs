using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Klassen implementerar metoder för uppgift 2 och 3
 */

namespace Uppgift2
{
    static class StringMachine
    {
        public static void PrintTenTimes()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}{1}", text, i < 9 ? ", " : "\n");
            }
        }

        public static void PrintThirdWord()
        {
            StringSplitOptions splitOptions =
                StringSplitOptions.TrimEntries |
                StringSplitOptions.RemoveEmptyEntries;

            string[] words;
            do
            {
                Console.Write("Enter at least 3 words: ");
                string text = Console.ReadLine();
                words = text.Split(' ', splitOptions);
            } while (words.Length < 3);

            Console.WriteLine($"Third word: {words[2]}");
        }
    }
}
