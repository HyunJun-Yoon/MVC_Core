using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetBlog.MVC6.DataContext;
using AspNetBlog.MVC6.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetBlog.MVC6.Controllers
{
    public class AccountController : Controller
    {

        // GET: /<controller>/
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User  model)
        {
            if(ModelState.IsValid)
            {              
                using (var db = new AspNetDbContext())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}
