using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetBlog.MVC6.DataContext;
using AspNetBlog.MVC6.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.MVC6.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new AspNetDbContext())
            {
                // ToList() returns all of the posts with type List<Post>
                var list = db.Posts.ToList();
                return View(list);
            }
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}