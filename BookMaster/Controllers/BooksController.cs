using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookMaster.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}