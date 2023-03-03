using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codice_Fiscale
{
    internal class User
    {
    

        public string Name { get; set; }
        public string Surname { get; set; }

        public string City { get; set; }

        public DateTime Birthday { get; set; }

        public User(string name , string surname , string city , DateTime birthday)
        {
            Name = name;
            Surname = surname;
            City = city;
            Birthday = birthday;
        }

    }
}
