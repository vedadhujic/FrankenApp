using FrankenApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrankenApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            User user = new User() { Id = 1, Name = "Vedad", Number = 12 };

            return View(user);
        }
    }
}