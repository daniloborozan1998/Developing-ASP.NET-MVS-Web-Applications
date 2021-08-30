using BookLibraryApp.Domain.Models;
using BookLibraryApp.ViewModels.ReservationsViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLibraryApp.ViewModels.BookViewModels;

namespace BookLibraryApp.Mapper
{
    public static class ReservationMapper
    {
        public static ReservationListViewModel ReservationToReservationListViewModel(Reservation reservation)
        {
            return new ReservationListViewModel()
            {
                Id = reservation.Id,
                MemberFullName = $"{reservation.Member.FirstName} {reservation.Member.LastName}",
                ReservationName = reservation.ReservationName,
                Price = reservation.Price,
                DateTime = reservation.DateTime,
                BookNames = reservation.ReservationBooks.Select(x=>x.Book.Name).ToList()
            };
        }

        public static ReservationDetailsViewModel ToReservationDetailsViewModel(this Reservation reservation)
        {
            return new ReservationDetailsViewModel()
            {
                Id = reservation.Id,
                PaymentMethod = reservation.PaymentMethod,
                MemberFullName = $"{reservation.Member.FirstName} {reservation.Member.LastName}",
                ReservationName = reservation.ReservationName,
                DateTime = reservation.DateTime,
                Price = reservation.Price,
                BookNames = reservation.ReservationBooks.Select(x=>x.Book.Name).ToList()
            };
        }

        public static Reservation ToReservationViewModel(this ReservationViewModel reservationViewModel)
        {
            return new Reservation()
            {
                PaymentMethod = reservationViewModel.PaymentMethod,
                ReservationName = reservationViewModel.ReservationName,
                DateTime = reservationViewModel.DateTime,
                ReservationBooks = new List<ReservationBook>(),
                MemberId = reservationViewModel.MemberId

            };
        }

        public static ReservationViewModel ToReservationViewModel(this Reservation reservation)
        {
            return new ReservationViewModel()
            {
                Id = reservation.Id,
                PaymentMethod = reservation.PaymentMethod,
                ReservationName = reservation.ReservationName,
                DateTime = reservation.DateTime,
                MemberId = reservation.MemberId
            };
        }
    }
}
