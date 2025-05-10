using Microsoft.AspNetCore.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaTravelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly AppDbContext _context;

        public DestinationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Destinations.Include(x => x.Country).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateDestination()
        {
            ViewBag.Countries = _context.Countries.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateDestination(Destination destination)
        {
            if (ModelState.IsValid)
            {
                _context.Destinations.Add(destination);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Countries = _context.Countries.ToList();
            return View(destination);
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var value = _context.Destinations.Find(id);
            if (value == null) return NotFound();

            ViewBag.Countries = _context.Countries.ToList();
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            if (ModelState.IsValid)
            {
                _context.Destinations.Update(destination);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Countries = _context.Countries.ToList();
            return View(destination);
        }

        [HttpGet]
        public IActionResult DeleteDestination(int id)
        {
            var value = _context.Destinations.Find(id);
            if (value == null) return NotFound();
            return View(value);
        }

        [HttpPost]
        public IActionResult DeleteDestination(Destination destination)
        {
            var value = _context.Destinations.Find(destination.Id);
            if (value == null) return NotFound();

            _context.Destinations.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
