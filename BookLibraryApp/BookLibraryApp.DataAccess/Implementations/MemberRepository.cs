using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;

namespace BookLibraryApp.DataAccess.Implementations
{
    public class MemberRepository : IRepository<Member>
    {
        public List<Member> GetAll()
        {
            return StaticDb.Members;
        }

        public Member GetById(int id)
        {
            return StaticDb.Members.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Member entity)
        {
            entity.Id = ++StaticDb.MemberId;
            StaticDb.Members.Add(entity);
            return entity.Id;
        }

        public void Update(Member entity)
        {
            Member member = StaticDb.Members.FirstOrDefault(x => x.Id == entity.Id);
            if (member == null)
            {
                throw new Exception($"Member with id {entity.Id} was not found ");
            }

            int index = StaticDb.Members.IndexOf(member);
            StaticDb.Members[index] = entity;
        }

        public void DeleteById(int id)
        {
            Member member = StaticDb.Members.FirstOrDefault(x => x.Id == id);
            if (member == null)
            {
                throw new Exception($"Member with id {id} was not found ");
            }

            StaticDb.Members.Remove(member);
        }
    }
}
