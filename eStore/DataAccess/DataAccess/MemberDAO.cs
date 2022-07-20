using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Member> GetMemberList()
        {
            var members = new List<Member>();
            try
            {
                using var context = new Ass2PRNContext();
                members = context.Members.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;

        }

        public Member GetMemberByID(int memberID)
        {
            Member member = null;
            try
            {
                using var context = new Ass2PRNContext();
                member = context.Members.SingleOrDefault(m => m.MemberId == memberID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public void AddMember(Member member)
        {
            try
            {
                Member member1 = GetMemberByID(member.MemberId);
                if (member1 == null)
                {
                    using var context = new Ass2PRNContext();
                    context.Members.Add(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Member is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Member is already exist");
            }
        }

        public void UpDate(Member member)
        {
            try
            {
                Member member1 = GetMemberByID(member.MemberId);
                if (member1 == null)
                {
                    using var context = new Ass2PRNContext();
                    context.Members.Update(member);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int memberID)
        {
            try
            {
                Member member = GetMemberByID(memberID);
                if (member != null)
                {
                    using var context = new Ass2PRNContext();
                    context.Members.Remove(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Member does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
