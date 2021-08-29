using System.Linq;
using AspNetBlog.MVC6.DataContext;
using AspNetBlog.MVC6.Models;
using AspNetBlog.MVC6.ViewModel;
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

        [HttpPost]
        public IActionResult SignIn(SignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AspNetDbContext())
                {
                    //Linq - method chaining
                    var user = db.Users
                        .FirstOrDefault(u => u.UserId.Equals(model.UserId) &&
                                        u.UserPassword.Equals(model.UserPassword));

                    if (user != null)
                    {
                        // Sign In Success
                        return RedirectToAction("LoginSuccess", "Home");

                    }

                }

                // Sign In Fail
                ModelState.AddModelError(string.Empty, "User ID and Password do not match");
            }
            return View(model);
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User model)
        {
            if (ModelState.IsValid)
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
