using System;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Views.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public Action Index(IActionResult actionResult)
        {
            return View();
        }
    }
}
