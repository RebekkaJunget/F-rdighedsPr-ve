using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public class MemberList
    {
        public List<Member> members {  get; set; }


        public MemberList()
        { 
            members = new List<Member>();
        
        }
        public void AddMember(Member member)
        {
            members.Add(member);
        }

       

        public void UpdateMember(Member member)
        {
            var index = members.FindIndex(m => m.Id == member.Id);
            if (index != -1)
            {
                members[index] = member;
            }
        }

        public void DeleteMember(int Id)
        {
            members.RemoveAll(m => m.Id == Id);

        }

        

        // public void ReadMember(Member member)
        //{ members.Read(member); }


    }
}
