using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Domain.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public List<Book> Books { get; set; }
    }
}
