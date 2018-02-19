using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1___String
{
    static class StringEdit
    {
        public static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        public static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        public static void PrintTitleCase(string str)
        {
            if (str.Length > 0)
            {   //TODO: Stop changing characters to strings and back it's dumb
                char[] print = new char[str.Length];
                print[0] = str[0].ToString().ToUpper()[0];
                for (int i = 1; i < str.Length; i++)
                {
                    print[i] = str[i].ToString().ToLower()[0];
                }
                Console.WriteLine(new string(print));
            }
        }

        public static void PrintReverse(string str)
        {
            char[] print = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                print[i] = str[str.Length - 1 - i];
            }
            Console.WriteLine(new string(print));
        }
    }
}
