using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using BookStore.Models;
using BookStore.ViewModels;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        public ViewResult Index()
        {
            var books = GetBooks();

            return View(books);
        }

        private IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Name = "Eragon" },
                new Book { Id = 2, Name = "Brisingr" }
            };
        }
        
        // GET: Books/Random
        public ActionResult Random()
        {
            var book = new Book(){Name = "War and Peace"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomBookViewModel
            {
                Book = book,
                Customers = customers
            };

            //ViewData["Book"] = book;
            //ViewBag.Book = book;

            return View(viewModel);
        }

        [Route("books/copyright/{year}")]
        public ActionResult ByCopyrightDate(int year)
        {
            return Content(year.ToString());
        }

        //routes.MapRoute("BooksByCopyrightDate",
        //    "books/copyright/{year}/{month}",
        //    new { controller = "Books", action = "ByCopyrightDate" });

    }
}