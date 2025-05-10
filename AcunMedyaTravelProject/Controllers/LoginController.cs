using Microsoft.AspNetCore.Mvc;
using AcunMedyaTravelProject.Models;
using AcunMedyaTravelProject.Context;
namespace AcunMedyaTravelProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;
        public LoginController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (model.Username == "admin" && model.Password == "1234")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Kullanıcı adı veya şifre hatalı.";
                return View();
            }
        }
    }
}
