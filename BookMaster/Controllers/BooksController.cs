using BookMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookMaster.Controllers
{
    public class BooksController : Controller
    {
        ApplicationDbContext data;
        public BooksController()
        {
            data = new ApplicationDbContext();
        }
        // GET: ShoppingCart
        public ActionResult ShoppingCart()
        {
            return View();
        }

        public ActionResult SearchBooks(String search)
        {
            return View(data.Books.Where(x => x.Title.Contains(search) || search == null).ToList());
        }
    }
}