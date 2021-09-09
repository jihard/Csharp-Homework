
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
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

        public string PutNumber(string name, string number)
        {
            int newnumber = Convert.ToInt32(number);
            _phoneDirectory.Add(name, newnumber);
            if (name == "" || number == "")
            {
                Console.WriteLine(" name or number is empty ");
            }
            return " name or number is empty "; 
        }
    }
}
