using BusinessObject;
using System;
using System.Linq;
using System.Collections.Generic;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<Member> listMember = new List<Member>
        {
            new Member(){MemberID=1, MemberName="QuangNguyen", Email="quang123@gmail.com", Password="12345", City="Ha Noi",Country="Viet Nam"},
            new Member(){MemberID=2, MemberName="NguyenQuang", Email="nguyn456@gmail.com", Password="12345", City="Ha Noi",Country="Viet Nam"},
        };

        public MemberDAO() { }

        public List<Member> GetMemberList()
        {
            return listMember;
        }

        public List<Member> GetMemberById(int id)
        {
            return listMember.Where(Member => id == Member.MemberID).ToList();
        }

        public List<Member> GetMemberByName(string name)
        {
            return listMember.Where(x => x.MemberName.ToLower().Contains(name.ToLower())).ToList();
        }
        public Member GetMemBerById(int id)
        {
            Member memberObject = listMember.SingleOrDefault(a => a.MemberID == id);
            return memberObject;
        }

        public void InsertMember(Member member)
        {
            Member memberObject = GetMemBerById(member.MemberID);
            if (memberObject == null)
            {
                listMember.Add(member);
            }
            else
            {
                throw new Exception("Member ID alrealy exists.");
            }

        }

        public void UpdateMember(Member member)
        {
            Member memberObject = GetMemBerById(member.MemberID);
            if (memberObject != null)
            {
                var index = listMember.IndexOf(memberObject);
                listMember[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }

        public void DeleteMemberById(int id)
        {
            Member memberObject = GetMemBerById(id);
            if (memberObject != null)
            {
                listMember.Remove(memberObject);
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
    }
}
