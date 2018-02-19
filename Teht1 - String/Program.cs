using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1___String
{
    class Program
    {
        delegate void ModifyString(string str);

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter text\n> ");
                string input = Console.ReadLine();
                Console.WriteLine("What would you like to do to the text?");
                Console.WriteLine("[1] Uppercase");
                Console.WriteLine("[2] Lowercase");
                Console.WriteLine("[3] Title case");
                Console.WriteLine("[4] Reverse");
                Console.WriteLine("[Q] Quit");
                ModifyString edit = delegate(string str) { };
                string action = Console.ReadLine();

                if (action.Contains("1")) { edit += StringEdit.PrintUpper; }
                if (action.Contains("2")) { edit += StringEdit.PrintLower; }
                if (action.Contains("3")) { edit += StringEdit.PrintTitleCase; }
                if (action.Contains("4")) { edit += StringEdit.PrintReverse; }

                edit(input);

                if (action.Contains("Q") || action.Contains("q")) { break; }
            }
        }
    }
}
