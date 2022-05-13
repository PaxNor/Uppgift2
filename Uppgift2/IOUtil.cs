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

        private static uint GetUInt32(string prompt)
        {
            uint output;
            do
            {
                Console.Write(prompt);
                success = uint.TryParse(Console.ReadLine(), out output);
            } while (success == false);

            return output;
        }

        public static uint GetUserInput(string prompt)
        {
            return GetUInt32(prompt);
        }

        // needs generic type
        public static uint GetUserInput(string prompt, TypeCode type)
        {
            switch(type)
            {
                case TypeCode.Char:
                    break;

                case TypeCode.UInt32:
                    break;

                default:
                    throw new NotImplementedException();
                    
            }

            return 0;
        }            
    }
}
