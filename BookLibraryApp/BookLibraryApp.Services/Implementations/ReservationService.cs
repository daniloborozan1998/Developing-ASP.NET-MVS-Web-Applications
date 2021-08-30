using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLibraryApp.DataAccess.Implementations;
using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Mapper;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.Shared.CustomExceptions;
using BookLibraryApp.ViewModels.ReservationsViewModel;

namespace BookLibraryApp.Services.Implementations
{
    public class ReservationService : IReservationService
    {
        private IRepository<Reservation> _reservationRepository;
        private IRepository<Member> _memberRepository;
        private IBookRepository _bookRepository;
        public ReservationService(IRepository<Reservation> reservationRepository, IRepository<Member> memberRepository, IBookRepository bookRepository)
        {
            _reservationRepository = reservationRepository;
            _memberRepository = memberRepository;
            _bookRepository = bookRepository;
        }
        
        public List<ReservationListViewModel> GetAllReservation()
        {
            List<Reservation> reservationsDb = _reservationRepository.GetAll();
            return reservationsDb.Select(x => ReservationMapper.ReservationToReservationListViewModel(x)).ToList();
        }

        public ReservationDetailsViewModel GetReservationDetails(int id)
        {
            Reservation reservationDb = _reservationRepository.GetById(id);
            if (reservationDb == null)
            {
                throw new Exception($"The reservation with id {id} was not found!");
            }

            return reservationDb.ToReservationDetailsViewModel();
        }

        public void AddBookToReservation(BookReservationViewModel bookReservationViewModel)
        {
            Book bookDb = _bookRepository.GetById(bookReservationViewModel.BookId);
            if (bookDb == null)
            {
                throw new Exception($"Book with id {bookReservationViewModel.BookId} was not found");
            }

            Reservation reservationDb = _reservationRepository.GetById(bookReservationViewModel.ReservationId);
            if (reservationDb == null)
            {
                throw new Exception($"Reservation with id {bookReservationViewModel.ReservationId} was not found");
            }

            reservationDb.ReservationBooks.Add(new ReservationBook()
            {
                Book = bookDb,
                IdBook = bookDb.Id
            });
            _reservationRepository.Update(reservationDb);
        }

        public ReservationViewModel GetReservationForEdit(int id)
        {
            Reservation reservationDb = _reservationRepository.GetById(id);
            if (reservationDb == null)
            {
                throw new ResourceNotFoundException($"The reservation with id {id} was not found!");
            }

            return reservationDb.ToReservationViewModel();
        }

        public void EditReservation(ReservationViewModel reservationViewModel)
        {
            Reservation reservationDb = _reservationRepository.GetById(reservationViewModel.Id);
            if (reservationDb == null)
            {
                throw new ResourceNotFoundException($"The reservation with id {reservationViewModel.Id} was not found!");
            }

            Member memberDb = _memberRepository.GetById(reservationViewModel.MemberId);
            if (memberDb == null)
            {
                throw new ResourceNotFoundException($"The memberDb with id {reservationViewModel.MemberId} was not found!");
            }

            Reservation editReservation = reservationViewModel.ToReservationViewModel();
            editReservation.Member = memberDb;
            editReservation.Id = reservationViewModel.Id;
            editReservation.ReservationBooks = reservationDb.ReservationBooks;
            _reservationRepository.Update(editReservation);
        }

        public void DeleteReservation(int id)
        {
            Reservation reservationDb = _reservationRepository.GetById(id);
            if (reservationDb == null)
            {
                throw new ResourceNotFoundException($"The reservation with id {id} was not found!");
            }
            _reservationRepository.DeleteById(id);
        }

        public void CreateReservation(ReservationViewModel reservationViewModel)
        {
            Member memberDb = _memberRepository.GetById(reservationViewModel.MemberId);
            if (memberDb == null)
            {
                throw new Exception($"User with id {reservationViewModel.MemberId} was not found!");
            }

            Reservation reservation = reservationViewModel.ToReservationViewModel();
            reservation.Member = memberDb;

            int newReservationId = _reservationRepository.Insert(reservation);
            if (newReservationId <= 0)
            {
                throw new Exception("An error occured while saving to db");
            }
        }
    }
}
