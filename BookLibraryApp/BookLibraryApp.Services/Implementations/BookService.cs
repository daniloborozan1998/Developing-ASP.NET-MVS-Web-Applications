using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Mapper;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.BookViewModels;

namespace BookLibraryApp.Services.Implementations
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<BookListViewModel> GetAllBook()
        {
            List<Book> bookDb = _bookRepository.GetAll();
            return bookDb.Select(x => BookMapper.BookToBookListViewModel(x)).ToList();
        }

        public BookDetailsViewModel GetBookDetails(int id)
        {
            Book bookDb = _bookRepository.GetById(id);
            if (bookDb == null)
            {
                throw new Exception($"The book with id {id} is not found");
            }

            return bookDb.BookToBookDetailsViewModel();
        }

        public void CreateBook(BookViewModel bookViewModel)
        {
            Book bookDb = bookViewModel.ToBookViewModel();
            int newBookId = _bookRepository.Insert(bookDb);
            if (newBookId <= 0)
            {
                throw new Exception("An errro occured while saving to db");
            }

        }

        public List<BookDDViewModel> GetBookDropDown()
        {
            List<Book> books = _bookRepository.GetAll();
            return books.Select(x => x.ToBookDdViewModel()).ToList();
        }
    }
}
