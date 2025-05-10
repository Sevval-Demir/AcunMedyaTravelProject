using Microsoft.AspNetCore.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;
using AcunMedyaTravelProject.Enums;

namespace AcunMedyaTravelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TourController : Controller
    {
        private readonly AppDbContext _context;

        public TourController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Tours.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTour()
        {
            ViewBag.TourCategories = Enum.GetValues(typeof(TourCategory));
            return View();
        }

        [HttpPost]
        public IActionResult CreateTour(Tour tour)
        {
            if (ModelState.IsValid)
            {
                _context.Tours.Add(tour);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TourCategories = Enum.GetValues(typeof(TourCategory));
            return View(tour);
        }

        [HttpGet]
        public IActionResult UpdateTour(int id)
        {
            var value = _context.Tours.Find(id);
            if (value == null) return NotFound();

            ViewBag.TourCategories = Enum.GetValues(typeof(TourCategory));
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTour(Tour tour)
        {
            if (ModelState.IsValid)
            {
                _context.Tours.Update(tour);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TourCategories = Enum.GetValues(typeof(TourCategory));
            return View(tour);
        }

        [HttpGet]
        public IActionResult DeleteTour(int id)
        {
            var value = _context.Tours.Find(id);
            if (value == null) return NotFound();

            return View(value);
        }

        [HttpPost]
        public IActionResult DeleteTour(Tour tour)
        {
            var value = _context.Tours.Find(tour.Id);
            if (value == null) return NotFound();

            _context.Tours.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
