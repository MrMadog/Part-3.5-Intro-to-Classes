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
        private int _age;

        public Name(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _title = "";
        }

        public Name(string firstName, string lastName, int age, string title)
        {
            _firstName = firstName;
            _lastName = lastName;
            _title = title;
            _age = age;
        }

        public void Greeting()
        {
            Console.WriteLine($"Hello! My name is {_firstName} {_lastName}, and I am {_age} years old!");
        }
    }

}

