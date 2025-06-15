using DemoController.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoController.Controllers
{
    public class BookController : Controller
    {
        static List<Book> books = new List<Book>()
        {
            new Book { BookId = 1, Title = "Thiết kế Web", Author = "HIENLTH", Price = 99000, IsExpire = false },
            new Book { BookId = 1, Title = "Lập trình ASP.NET Core", Author = "HIENLTH", Price = 159000, IsExpire = false },
        };

        public IActionResult Index()
        {
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            //Validate the book object
            books.Add(book);
            return RedirectToAction("Index");
        }

        //public IActionResult Create(Book book)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        books.Add(book);
        //        return RedirectToAction("Index");
        //    }
        //    return View(book);
        //}
    }
}
