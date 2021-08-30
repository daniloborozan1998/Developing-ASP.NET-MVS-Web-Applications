using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.ViewModels.BookViewModels;

namespace BookLibraryApp.Mapper
{
    public static class BookMapper
    {
        public static BookListViewModel BookToBookListViewModel(Book book)
        {
            return new BookListViewModel()
            {
                Id = book.Id,
                Author = book.Author,
                GenreBook = book.GenreBook,
                Name = book.Name,
                Price = book.Price,
                Publisher = book.Publisher
            };
        }

        public static BookDetailsViewModel BookToBookDetailsViewModel(this Book book)
        {
            return new BookDetailsViewModel()
            {
                Id = book.Id,
                Author = book.Author,
                GenreBook = book.GenreBook,
                Name = book.Name,
                Price = book.Price,
                Publisher = book.Publisher
            };
        }

        public static Book ToBookViewModel(this BookViewModel bookViewModel)
        {
            return new Book()
            {
                Id = bookViewModel.Id,
                Author = bookViewModel.Author,
                GenreBook = bookViewModel.GenreBook,
                Name = bookViewModel.Name,
                Price = bookViewModel.Price,
                Publisher = bookViewModel.Publisher
            };
        }

        public static BookDDViewModel ToBookDdViewModel(this Book book)
        {
            return new BookDDViewModel()
            {
                Id = book.Id,
                Name = book.Name
            };
        }

    }
}
