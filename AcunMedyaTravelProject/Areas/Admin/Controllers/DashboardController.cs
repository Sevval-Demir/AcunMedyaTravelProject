using AcunMedyaTravelProject.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AcunMedyaTravelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.TotalCountries = _context.Countries.Count();
            ViewBag.TotalDestinations = _context.Destinations.Count();
            ViewBag.TotalPackages = _context.Packages.Count();
            ViewBag.TotalGuides = _context.Guides.Count();
            ViewBag.TotalBookings = _context.Bookings.Count();
            ViewBag.TotalTestimonials = _context.Testimonials.Count();
            ViewBag.TotalTours = _context.Tours.Count();

            var last5 = _context.Bookings.OrderByDescending(x => x.Date).Take(5).ToList();
            return View(last5);
        }
    }
}
