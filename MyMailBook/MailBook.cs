using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMailBook
{
    class MailBook
    {
        private List<Friend> Friends;

        public MailBook(string path)
        {
            Friends = new List<Friend>();
            try
            { 
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] lineItems = line.Split(',');
                        if (lineItems.Length > 1)
                        {
                            Friends.Add(new Friend(lineItems[0], lineItems[1]));
                        }
                    }

                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Path invalid:\n" + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Input/Output error:\n" + e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine("Operation not permitted:\n" + e.Message);
            }
        }

        internal string[] Search(string search)
        {
            List<Friend> result = Friends.FindAll(x => x.Name.StartsWith(search, true, System.Globalization.CultureInfo.InvariantCulture));
            if (result.Count == 0) { return new string[0]; }
            string[] resultStrings = new string[result.Count];
            for (int i = 0; i < result.Count; i++)
            {
                resultStrings[i] = result.ElementAt(i).Name;
            }
            return resultStrings;
        }

        public void List()
        {
            Console.WriteLine(Friends.Count + " names in address book:");
            foreach (Friend friend in Friends)
            {
                Console.WriteLine(friend.Name);
            }
        }
    }
}
