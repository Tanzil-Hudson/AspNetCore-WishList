using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Views.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        
        public IActionResult Error()
        {
            return View("Error");
        }

    }

}
