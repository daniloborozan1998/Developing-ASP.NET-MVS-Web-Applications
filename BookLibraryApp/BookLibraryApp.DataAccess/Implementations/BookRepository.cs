using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;

namespace BookLibraryApp.DataAccess.Implementations
{
    public class BookRepository : IBookRepository
    {
        public List<Book> GetAll()
        {
            return StaticDb.Books;
        }

        public Book GetById(int id)
        {
            return StaticDb.Books.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Book entity)
        {
            entity.Id = ++StaticDb.BookId;
            StaticDb.Books.Add(entity);
            return entity.Id;
        }

        public void Update(Book entity)
        {
            Book book = StaticDb.Books.FirstOrDefault(x => x.Id == entity.Id);
            if (book == null)
            {
                throw new Exception($"Book with id {entity.Id} does not exists");
            }
            int index = StaticDb.Books.IndexOf(book);
            StaticDb.Books[index] = entity;
        }

        public void DeleteById(int id)
        {
            Book book = StaticDb.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                throw new Exception($"Book with id {id} not found");
            }

            StaticDb.Books.Remove(book);
        }
    }
}
