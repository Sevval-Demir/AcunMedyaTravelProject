using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaTravelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            if (ModelState.IsValid)
            {
                _context.Abouts.Add(about);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(about);
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            if (ModelState.IsValid)
            {
                _context.Abouts.Update(about);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(about);
        }
        [HttpGet]
        public IActionResult DeleteAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            return View(value);
        }
        [HttpPost]
        public IActionResult DeleteAbout(About about)
        {
            var value = _context.Abouts.Find(about.Id);
            if (value == null)
            {
                return NotFound();
            }
            _context.Abouts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
