using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        MemberDAO memberDAO = new MemberDAO();
        public void deleteMember(int id)
        {
            memberDAO.DeleteMemberById(id);
        }

        public IEnumerable<Member> getMembers()
        {
            return memberDAO.GetMemberList();
        }

        public Member GetMemberById(int id)
        {
            return memberDAO.GetMemBerById(id);
        }

        public void insertMember(Member member)
        {
            memberDAO.InsertMember(member);
        }

        public void updateMember(Member member)
        {
            memberDAO.UpdateMember(member);
        }

        public IEnumerable<Member> getMemberById(int id)
        {
            return memberDAO.GetMemberById(id);
        }

        public IEnumerable<Member> getMembersByName(string name)
        {
            return memberDAO.GetMemberByName(name);
        }


    }
}