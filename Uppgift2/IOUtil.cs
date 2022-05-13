using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2


/*
 * Klassen implementerar hjälp metod för att hämta in och validera
 * andvändarinput från konsollen. Metoden upprepar försök tills 
 * dess att ett giltigt svar angivits.
 */

{
    static class IOUtil
    {
        private static bool success;

        private static uint GetUserInput(string prompt)
        {
            uint output;
            do
            {
                Console.Write(prompt);
                success = uint.TryParse(Console.ReadLine(), out output);
            } while (success == false);

            return output;
        }    
    }
}
