using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        List<Dog> OwnDog { get; set; } = new List<Dog> ();




        public Member(int id, string name,string address, string phone, string email, List<Dog> dogs)
        {
            Id = id;
            Name = name;
            Address = address;
           // DateTime BirthDate;
            Phone = phone;
            Email = email;
            OwnDog = dogs;
        }

        
        List<Member> members = new List<Member>();

       

        public void RegisterDog(List<Dog> dogs)
        {
            

         
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Address: {Address}, BirthDate: {BirthDate}, Phone {Phone}, Email: {Email}. ";
        }

    }
}


