using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BookLibraryApp.Domain.Enums;

namespace BookLibraryApp.ViewModels.BookViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Book Name")]
        public string Name { get; set; }
        [Display(Name = "Genre Book")]
        public GenreBook GenreBook { get; set; }
        [Display(Name = "Price")]
        public int Price { get; set; }
        [Display(Name = "Author")]
        public string Author { get; set; }
        [Display(Name = "Publisher")]
        public string Publisher { get; set; }
    }
}
