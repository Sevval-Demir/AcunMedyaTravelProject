using Microsoft.AspNetCore.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class CountryController : Controller
    {
        private readonly AppDbContext _context;

        public CountryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Countries.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCountry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCountry(Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Countries.Add(country);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(country);
        }

        [HttpGet]
        public IActionResult UpdateCountry(int id)
        {
            var value = _context.Countries.Find(id);
            return value == null ? NotFound() : View(value);
        }

        [HttpPost]
        public IActionResult UpdateCountry(Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Countries.Update(country);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(country);
        }

        [HttpGet]
        public IActionResult DeleteCountry(int id)
        {
            var value = _context.Countries.Find(id);
            return value == null ? NotFound() : View(value);
        }

        [HttpPost]
        public IActionResult DeleteCountry(Country country)
        {
            var value = _context.Countries.Find(country.Id);
            if (value == null) return NotFound();

            _context.Countries.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
