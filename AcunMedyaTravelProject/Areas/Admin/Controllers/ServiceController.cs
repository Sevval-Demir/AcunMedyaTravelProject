using Microsoft.AspNetCore.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Services.Add(service);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(service);
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = _context.Services.Find(id);
            return value == null ? NotFound() : View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Services.Update(service);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(service);
        }

        [HttpGet]
        public IActionResult DeleteService(int id)
        {
            var value = _context.Services.Find(id);
            if (value == null)
                return NotFound();

            return View(value);
        }

        [HttpPost]
        public IActionResult DeleteService(Service service)
        {
            var value = _context.Services.Find(service.Id);
            if (value == null) return NotFound();

            _context.Services.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
