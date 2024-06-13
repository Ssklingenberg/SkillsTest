using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Member
    {
        public int _id;
        public string _name;
        public string _address;
        public DateTime _birthday;
        public string _phone;
        public string _email;
        public List<Dog> _dogs = new List<Dog>();
        public int _Age;


        public Member(int id, string name, string address, DateTime birthday, string phone, string email)
        {
            _id = id;
            _name = name;
            _address = address;
            _birthday = birthday;
            _phone = phone;
            _email = email;
        }

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public DateTime BirthDay { get { return _birthday; } set { _birthday = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string Email { get { return _email; } set { _email = value; } }

        public int Age => DateTime.Now.Year - BirthDay.Year;


        public override string ToString()
        {
            return $"ID:{ID}, Name:{Name}, Address:{Address}, Birthday: {BirthDay}, Phone: {Phone}, Email:{Email}, Age{Age}";
        }

        public void RegisterDog(Dog dog)
        {
            _dogs.Add(dog);
        }

        public void PrintDogs()
        {
            foreach (Dog dog in _dogs)
                Console.WriteLine(dog.ToString());
        }
        public void RemoveDog(Dog dog)
        { _dogs.Remove(dog); }

        public double MemberFee(double baseFee)
        {
            if
            (_dogs.Count < 2 && Age > 65 || _dogs.Count >= 2 && Age > 65 || _dogs.Count < 2 && Age > 65)
            {
                return 500;
            }
            return baseFee;
        }
        //public bool Validate()
        //{
        //    if (Age > 18 && string.IsNullOrEmpty("Name, Address, Phone, Email"))
        //    {
        //        return false;
        //    }
        //    else return true;

        //}
        public bool Validate()
        {
            if (Age > 18 && string.IsNullOrEmpty("Name, Address, Phone, Email"))
            {
                throw new Exception("Age under 18 or emty fields");
            }
            return true;
        }
    }
}



