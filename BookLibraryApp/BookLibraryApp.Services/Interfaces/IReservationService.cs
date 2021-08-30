using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryApp.ViewModels.ReservationsViewModel;

namespace BookLibraryApp.Services.Interfaces
{
    public interface IReservationService
    {
        List<ReservationListViewModel> GetAllReservation();
        void CreateReservation(ReservationViewModel reservationViewModel);
        ReservationDetailsViewModel GetReservationDetails(int id);
        void AddBookToReservation(BookReservationViewModel bookReservationViewModel);
        ReservationViewModel GetReservationForEdit(int id);
        void EditReservation(ReservationViewModel reservationViewModel);
        void DeleteReservation(int id);
    }
}
