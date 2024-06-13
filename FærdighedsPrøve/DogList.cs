using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public class DogList
    {
        private object member;

        public List<Dog> _dogs { get; set; }

        

        public void AddDogs(Dog dog) {  _dogs.Add(dog); }

        public void UpdateDogs(Dog dog)
        {
            var index = _dogs.FindIndex(d => d.Id == dog.Id);
            if (index != -1)
            {
                _dogs[index] = dog;
            }
        }
            
        public void RemoveDogs(int id) 
        { 
            _dogs.RemoveAll(d=>d.Id == id); 
        }

        public override string ToString()
        {
            string dogsString = string.Join(" ", _dogs);
            return $"Dogs: {dogsString}";
        }

    }
}
