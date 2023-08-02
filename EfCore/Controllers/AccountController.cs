using Microsoft.AspNetCore.Mvc;

namespace EfCore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {

            if (username == "testuser" && password == "password")
            {

                return RedirectToAction("GetCategories", "Category");
            }
            else
            {

                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı!";
                return View();
            }
        }
    }
}