using OnionApp.Domain.Core.Entities;
using OnionApp.Domain.Interfaces.Interfaces;
using OnionApp.Services.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnionApp.Controllers
{
    public class HomeController : Controller
    {
        IBookRepository _repos;
        IOrder _order;
        public HomeController(IBookRepository repos, IOrder order)
        {
            _repos = repos;
            _order = order;
        }
        public ActionResult Index()
        {
            var books = _repos.GetBookList();
            return View(books);
        }
        public ActionResult Buy(int id)
        {
            Book book = _repos.GetBook(id);
            _order.MakeOrder(book);
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            _repos.Dispose();
            base.Dispose(disposing);
        }
    }
}