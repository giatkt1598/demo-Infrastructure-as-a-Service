using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectIaaS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectIaaS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BooksContext _dbContext;

        public HomeController(ILogger<HomeController> logger, BooksContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var books = _dbContext.Books.ToList();
            return View(books);
        }

        public IActionResult Add(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        } 

        public IActionResult Delete(Book book)
        {
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
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
