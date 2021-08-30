using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryApp.Domain.Enums;
using BookLibraryApp.Domain.Models;

namespace BookLibraryApp.ViewModels.BookViewModels
{
    public class BookListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenreBook GenreBook { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

    }
}
