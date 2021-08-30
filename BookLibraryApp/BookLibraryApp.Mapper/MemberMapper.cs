using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.ViewModels.MemberViweModels;

namespace BookLibraryApp.Mapper
{
    public static class MemberMapper
    {
        public static MemberDDViewModel ToMemberDdViewModel(this Member member)
        {
            return new MemberDDViewModel()
            {
                Id = member.Id,
                FullName = $"{member.FirstName} {member.LastName}",
                Age = member.Age
            };
        }
    }
}
