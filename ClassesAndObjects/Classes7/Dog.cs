using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes7
{
    public class Dog
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Mother { get; set; }
        public string Father { get; set; }

        public Dog(string name, string sex, string mother, string father)
        {
            this.Name = name;
            this.Sex = sex;
            this.Mother = mother;
            this.Father = father;
        }

        public string FathersName()
        {
            string fatherdata = Father == null ? "Unknown" : Father;
            Console.WriteLine(fatherdata);
            return fatherdata;
        }

        public bool HasSameMothersAS(Dog dog)
        {
            Console.WriteLine(dog.Mother);
            return this.Mother == dog.Mother;
        }
    }
}
