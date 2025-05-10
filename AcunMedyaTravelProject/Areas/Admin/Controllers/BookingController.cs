using Microsoft.AspNetCore.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaTravelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class BookingController : Controller
    {
        private readonly AppDbContext _context;
        public BookingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Bookings.Include(x => x.Package).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateBooking()
        {
            ViewBag.Packages = _context.Packages.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateBooking(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Packages = _context.Packages.ToList();
            return View(booking);
        }
        [HttpGet]
        public IActionResult UpdateBooking(int id)
        {
            var value = _context.Bookings.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            ViewBag.Packages = _context.Packages.ToList();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateBooking(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Bookings.Update(booking);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Packages = _context.Packages.ToList();
            return View(booking);
        }
        [HttpGet]
        public IActionResult DeleteBooking(int id)
        {
            var value = _context.Bookings.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            return View(value);
        }
        [HttpPost]
        public IActionResult DeleteBooking(Booking booking)
        {
            var value = _context.Bookings.Find(booking.Id);
            if (value == null)
            {
                return NotFound();
            }
            _context.Bookings.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
