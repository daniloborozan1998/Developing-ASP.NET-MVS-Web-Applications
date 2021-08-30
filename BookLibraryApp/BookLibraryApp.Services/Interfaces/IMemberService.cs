using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryApp.ViewModels.MemberViweModels;

namespace BookLibraryApp.Services.Interfaces
{
    public interface IMemberService
    {
        List<MemberDDViewModel> GetMemberDdViewModels();
    }
}
