using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibraryApp.Services.Implementations;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.Shared.CustomExceptions;
using BookLibraryApp.ViewModels.ReservationsViewModel;

namespace BookLibraryApp.Controllers
{
    public class ReservationController : Controller
    {
        private IReservationService _reservationService;
        private IMemberService _memberService;
        private IBookService _bookService;

        public ReservationController(IReservationService reservationService, IMemberService memberService, IBookService bookService)
        {
            _reservationService = reservationService;
            _memberService = memberService;
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            List<ReservationListViewModel> reservationListViewModels = _reservationService.GetAllReservation();
            return View(reservationListViewModels);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }

            try
            {
                ReservationDetailsViewModel reservationDetailsViewModel =
                    _reservationService.GetReservationDetails(id.Value);
                return View(reservationDetailsViewModel);
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }

        public IActionResult Create()
        {
            ReservationViewModel reservationViewModel = new ReservationViewModel();
            ViewBag.Members = _memberService.GetMemberDdViewModels();
            return View(reservationViewModel);
        }

        [HttpPost]
        public IActionResult Create(ReservationViewModel reservation)
        {
            try
            {
                _reservationService.CreateReservation(reservation);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }

        public IActionResult AddBook(int id)
        {
            BookReservationViewModel bookReservationViewModel = new BookReservationViewModel();
            bookReservationViewModel.ReservationId = id;
            ViewBag.Books = _bookService.GetBookDropDown();
            return View(bookReservationViewModel);
        }

        [HttpPost]
        public IActionResult AddBook(BookReservationViewModel bookReservationViewModel)
        {
            try
            {
                _reservationService.AddBookToReservation(bookReservationViewModel);
                return RedirectToAction("Details", new {id = bookReservationViewModel.ReservationId});
            }
            catch (Exception e)
            {
               return View("ExceptionPage");
            }
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }

            try
            {
                ReservationViewModel model = _reservationService.GetReservationForEdit(id.Value);
                ViewBag.Members = _memberService.GetMemberDdViewModels();
                return View(model);
            }
            catch (ResourceNotFoundException e)
            {
                return View("ResourceNotFound");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }

        [HttpPost]
        public IActionResult Edit(ReservationViewModel reservationViewModel)
        {
            try
            {
                _reservationService.EditReservation(reservationViewModel);
                return RedirectToAction("Index");
            }
            catch (ResourceNotFoundException e)
            {
                return View("ResourceNotFound");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                ReservationDetailsViewModel reservationDetailsViewModel = _reservationService.GetReservationDetails(id.Value);
                return View(reservationDetailsViewModel);
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }

        [HttpPost]
        public IActionResult Delete(ReservationDetailsViewModel reservationDetailsViewModel)
        {
            try
            {
                _reservationService.DeleteReservation(reservationDetailsViewModel.Id);
                return RedirectToAction("Index");
            }
            catch (ResourceNotFoundException e)
            {
                return View("ResourceNotFound");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }
    }
}
