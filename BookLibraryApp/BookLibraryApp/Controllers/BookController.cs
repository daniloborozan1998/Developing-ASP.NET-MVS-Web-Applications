using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.BookViewModels;

namespace BookLibraryApp.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;
        private IReservationService _reservationService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            List<BookListViewModel> bookListViewModels = _bookService.GetAllBook();
            return View(bookListViewModels);
        }

        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return View("BadRequest");
            }

            try
            {
                BookDetailsViewModel bookDetailsViewModel = _bookService.GetBookDetails(id.Value);
                return View(bookDetailsViewModel);
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }

        public IActionResult Create()
        {
            BookViewModel bookViewModel = new BookViewModel();
            return View(bookViewModel);
        }

        [HttpPost]
        public IActionResult Create(BookViewModel bookViewModel)
        {
            try
            {
                _bookService.CreateBook(bookViewModel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }
    }
}
