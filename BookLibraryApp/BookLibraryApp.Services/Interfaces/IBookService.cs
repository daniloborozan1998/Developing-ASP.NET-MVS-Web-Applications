using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryApp.ViewModels.BookViewModels;

namespace BookLibraryApp.Services.Interfaces
{
    public interface IBookService
    {
        List<BookListViewModel> GetAllBook();
        BookDetailsViewModel GetBookDetails(int id);
        void CreateBook(BookViewModel bookViewModel);
        List<BookDDViewModel> GetBookDropDown();
    }
}
