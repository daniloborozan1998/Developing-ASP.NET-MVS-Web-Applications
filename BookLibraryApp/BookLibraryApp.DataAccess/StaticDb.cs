using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLibraryApp.Domain.Enums;
using BookLibraryApp.Domain.Models;
using Microsoft.VisualBasic;

namespace BookLibraryApp.DataAccess
{
    public static class StaticDb
    {
        static StaticDb()
        {
            ReservationId = 3;
            BookId = 2;
            MemberId = 2;
            ReservationBookId = 3;
            AuthorsId = 2;
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Author = "Саманта Јанг",
                    GenreBook = GenreBook.Romance,
                    Name = "Херој",
                    Publisher = "Laguna",
                    Price = 420,
                    ReservationBook = new List<ReservationBook>()
                    {

                    }
                },
                new Book()
                {
                    Id = 2,
                    Author = "Сербер де Меделсхајм",
                    GenreBook = GenreBook.Business,
                    Name = "120 златни правила во трговијата",
                    Publisher = "IKONA",
                    Price = 399,
                    ReservationBook = new List<ReservationBook>()
                    {

                    }
                },
                new Book()
                {
                    Id = 3,
                    Author = "Жарко Марковски",
                    GenreBook = GenreBook.Adventure,
                    Name = "In vino veritas",
                    Publisher = "Жарко Марковски",
                    Price = 320,
                    ReservationBook = new List<ReservationBook>()
                    {

                    }
                }
            };

            Members = new List<Member>()
            {
                new Member()
                {
                    Id = 1,
                    FirstName = "Danilo",
                    LastName = "Borozan",
                    Age = 23,
                    Reservations = new List<Reservation>()
                    {

                    }
                },
                new Member()
                {
                    Id = 2,
                    FirstName = "Anamarija",
                    LastName = "Risteska",
                    Age = 24,
                    Reservations = new List<Reservation>()
                    {

                    }
                },
                new Member()
                {
                    Id = 3,
                    FirstName = "Sime",
                    LastName = "Nokoski",
                    Age = 22,
                    Reservations = new List<Reservation>()
                    {

                    }
                },
                new Member()
                {
                    Id = 1,
                    FirstName = "Rozeta",
                    LastName = "Markovska",
                    Age = 24,
                    Reservations = new List<Reservation>()
                    {

                    }
                }
            };
            Reservations = new List<Reservation>()
            {
                new Reservation()
                {
                    Id = 1,
                    DateTime = "12-09-2021 14:00",
                    PaymentMethod = PaymentMethodEnums.Card,
                    ReservationName = "Danilo",
                    ReservationBooks = new List<ReservationBook>()
                    {
                        new ReservationBook()
                        {
                            Id = 1,
                            Book = Books[0],
                            IdBook = Books[0].Id,
                            IdReservation = 1
                        },
                        new ReservationBook()
                        {
                            Id = 2,
                            Book = Books[1],
                            IdBook = Books[1].Id,
                            IdReservation = 1
                        }
                    },
                    Member = Members[0]
                },
                new Reservation()
                {
                    Id = 2,
                    DateTime = "22-09-2021 17:00",
                    PaymentMethod = PaymentMethodEnums.Cash,
                    ReservationName = "Anamarija",
                    ReservationBooks = new List<ReservationBook>()
                    {
                        new ReservationBook()
                        {
                            Id = 3,
                            Book = Books[2],
                            IdBook = Books[2].Id,
                            IdReservation = 2
                        }
                    },
                    Member = Members[1]
                }

            };

        }

        public static int ReservationId { get; set; }
        public static int BookId { get; set; }
        public static int MemberId { get; set; }
        public static int ReservationBookId { get; set; }
        public static int AuthorsId { get; set; }
        public static List<Book> Books { get; set; }
        public static List<Author> Authors { get; set; }
        public static List<Member> Members { get; set; }
        public static List<Reservation> Reservations { get; set; }
    }
}
