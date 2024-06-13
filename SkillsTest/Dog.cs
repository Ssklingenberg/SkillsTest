using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Dog
    {
        public int _id;
        public string _name;
        public string _race;
        public int _yearOfBirth;
        public Dog(int id, string name, string race, int yearOfBirth)
        {
            _id = id;
            _name = name;
            _race = race;
            _yearOfBirth = yearOfBirth;

        }
        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Race { get { return _race; } set { _race = value; } }

        public int YearOfBirth { get { return _yearOfBirth; } set { _yearOfBirth = value; }

        }
        public override string ToString()
        {
            return $"ID:{ID}, Name:{Name}, Race:{Race}, Year of Birth:{YearOfBirth}";
        }
    }
}
