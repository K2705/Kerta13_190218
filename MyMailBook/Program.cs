using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMailBook
{
    class Program
    {
        static void Main(string[] args)
        {
            MailBook mailBook = new MailBook(@"D:\K2705\mailbook.csv");
            mailBook.List();
            Console.Write("Enter search string\n> ");
            string search = Console.ReadLine();
            string[] result = mailBook.Search(search);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
