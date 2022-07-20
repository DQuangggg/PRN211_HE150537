using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Repository
{
    public class MemberRepository : IMemeberRepository
    {
        public void AddMember(Member member) => MemberDAO.Instance.AddMember(member);

        public void DeleteMember(int memberID) => MemberDAO.Instance.Remove(memberID);

        public Member GetMemberByID(int memberID) => MemberDAO.Instance.GetMemberByID(memberID);


        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();


        public void UpdateMember(Member member) => MemberDAO.Instance.UpDate(member);
    }
}
