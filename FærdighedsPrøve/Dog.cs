using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public class Dog
    {
        public int _id;
        public string _name;
        public string _race;
        public string _yearOfBirth;

        public Dog(int id, string name, string race, string yearOfBirth) 
        { 
            _id = id;
            _name = name;
            _race = race;
            _yearOfBirth = yearOfBirth;
        
        }

        public int Id { get { return _id; } }
        public string Name { get { return _name;} }
        public string Race { get { return _race; } }
        public string YearOfBirth { get {  return _yearOfBirth; } }


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Race: {Race}, YearOfBirth: {YearOfBirth}.";
        }

       
    }
}
