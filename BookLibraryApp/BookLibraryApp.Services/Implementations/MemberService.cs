using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLibraryApp.DataAccess.Implementations;
using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Mapper;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.MemberViweModels;

namespace BookLibraryApp.Services.Implementations
{
    public class MemberService : IMemberService
    {
        private IRepository<Member> _memberRepository;
        
        public MemberService(IRepository<Member> memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public List<MemberDDViewModel> GetMemberDdViewModels()
        {
            List<Member> membersDb = _memberRepository.GetAll();
            return membersDb.Select(x => x.ToMemberDdViewModel()).ToList();
        }
    }
}
