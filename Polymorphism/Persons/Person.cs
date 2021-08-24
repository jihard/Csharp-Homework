using System;

namespace Persons
{
    class Person
    {
        public string _firstname;
        public string _lastname;
        public int _age;
        public string _address;

        public Person(int age, string _firstname, string _lastname, string address)
        {
            this._firstname = _firstname;
            this._lastname = _lastname;
            this._age = age;
            this._address = address;
        }
    }
}