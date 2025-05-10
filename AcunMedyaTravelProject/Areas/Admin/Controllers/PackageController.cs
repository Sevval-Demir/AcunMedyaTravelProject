using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PackageController : Controller
    {
        private readonly AppDbContext _context;

        public PackageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Packages.Include(p => p.Destination).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePackage()
        {
            ViewBag.Destinations = _context.Destinations.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CreatePackage(Package package)
        {
            if (ModelState.IsValid)
            {
                _context.Packages.Add(package);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Destinations = _context.Destinations.ToList();
            return View(package);
        }

        [HttpGet]
        public IActionResult UpdatePackage(int id)
        {
            var value = _context.Packages.Find(id);
            if (value == null) return NotFound();

            ViewBag.Destinations = _context.Destinations.ToList();
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePackage(Package package)
        {
            if (ModelState.IsValid)
            {
                _context.Packages.Update(package);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Destinations = _context.Destinations.ToList();
            return View(package);
        }

        [HttpGet]
        public IActionResult DeletePackage(int id)
        {
            var value = _context.Packages.Find(id);
            if (value == null) return NotFound();
            return View(value);
        }

        [HttpPost]
        public IActionResult DeletePackage(Package package)
        {
            var value = _context.Packages.Find(package.Id);
            if (value == null) return NotFound();

            _context.Packages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
