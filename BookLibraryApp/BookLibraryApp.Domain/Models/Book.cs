using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryApp.Domain.Enums;

namespace BookLibraryApp.Domain.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public GenreBook GenreBook { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public List<ReservationBook> ReservationBook { get; set; }
    }
}
