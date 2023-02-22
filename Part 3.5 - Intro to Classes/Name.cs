using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part_3._5___Intro_to_Classes
{
    public class Name
    {
        private string _title;
        private string _firstName;
        private string _lastName;

        public Name(string firstName, string lastName, string title)
        {
            _firstName = firstName;
            _lastName = lastName;
            _title = title;
        }
        public Name(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _title = "";
        }
        }
    }

