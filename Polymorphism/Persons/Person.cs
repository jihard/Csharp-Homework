using System;

namespace Persons
{
    class Person
    {
        public string firstname;
        public string lastname;
        public int age;
        public string address;

        public Person(int age, string _firstname, string _lastname, string address)
        {
            this.firstname = _firstname;
            this.lastname = _lastname;
            this.age = age;
            this.address = address;
        }
    }
}