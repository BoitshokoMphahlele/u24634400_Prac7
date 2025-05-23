using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24634400_Prac7.Models
{
    public class Author
    {
        private string _Name;
        private string _Surname;

        public Author(string firstname, string lastname) { 
            _Name = firstname;
            _Surname = lastname;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        public string FullName => $"{Name} {Surname}";
    }
}