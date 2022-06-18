using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> getMembers();
        IEnumerable<Member> getMemberById(int id);
        IEnumerable<Member> getMembersByName(string name);
        Member GetMemberById(int id);
        void insertMember(Member member);
        void updateMember(Member member);
        void deleteMember(int id);
    }
}
