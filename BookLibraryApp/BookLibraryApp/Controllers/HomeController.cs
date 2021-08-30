using BookLibraryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.HomeViewModels;

namespace BookLibraryApp.Controllers
{
    public class HomeController : Controller
    {
        private IBookService _bookService;
        private IReservationService _reservationService;

        public HomeController(IBookService bookService, IReservationService reservationService)
        {
            _bookService = bookService;
            _reservationService = reservationService;
        }


        public IActionResult Index()
        {
            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel();
            homeIndexViewModel.ReservationCount = _reservationService.GetAllReservation().Count;
            homeIndexViewModel.BookCount = _bookService.GetAllBook().Count;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
