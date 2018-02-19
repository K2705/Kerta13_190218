using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMailBook
{
    class Friend
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Friend(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
