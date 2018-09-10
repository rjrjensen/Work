using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        // GET: Book/Random
        public ActionResult Random()
        {
            var book = new Book() { Name = "War and Peace"};

            return View(book);
        }
    }
}