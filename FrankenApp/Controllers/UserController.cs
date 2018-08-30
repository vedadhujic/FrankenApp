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

        public ActionResult ListOfUsers()
        {
            List<User> users = new List<User>();

            users.Add(new User { Id = 11, Name = "Jedan", Number = 111 });
            users.Add(new User { Id = 22, Name = "Dva", Number = 222 });
            users.Add(new User { Id = 33, Name = "Tri", Number = 333 });

            return View(users);
        }
    }
}