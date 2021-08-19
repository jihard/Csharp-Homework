using System;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, int> _phoneDirectory;

        public PhoneDirectory()
        {
            _phoneDirectory = new SortedDictionary<string, int>();
        }

        public int? GetNumber(string name)
        {
            foreach (var phone in _phoneDirectory)
            {
                if (_phoneDirectory.ContainsKey(name))
                {
                    return _phoneDirectory[name];
                }
            }
            return null;
        }

        public int? ListNumbers()
        {
            foreach (KeyValuePair<string, int> phone in _phoneDirectory)
            {
                Console.WriteLine($"Name: {phone.Key}, Phone number: {phone.Value}");
            }
            return null;
        }

        public void PutNumber(string name, string number)
        {
            int newnumber = Convert.ToInt32(number);
            _phoneDirectory.Add(name, newnumber);
            if (name == "" || number == "")
            {
                Console.WriteLine(" name and number cannot be empty ");
            }
        }
    }
}