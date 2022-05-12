using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    static class IOUtil
    {
        private static bool success;

        public static uint GetUInt32(string prompt)
        {
            uint output;
            do
            {
                Console.Write(prompt);
                success = uint.TryParse(Console.ReadLine(), out output);
            } while (success == false);

            return output;
        }

        // generic return type
        public static int GetInput(string prompt, TypeCode type)
        {
            switch(type)
            {
                case TypeCode.Boolean:
                    break;
                case TypeCode.Char:
                    break;
                case TypeCode.Int16:
                    break;
                // and so on..

                default:
                    break;
            }

            return 0;
        }            
    }
}
