using Microsoft.AspNetCore.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class GuideController : Controller
    {
        private readonly AppDbContext _context;
        public GuideController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var guides = _context.Guides.ToList();
            return View(guides);
        }
        [HttpGet]
        public IActionResult CreateGuide()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateGuide(Guide guide)
        {
            if (ModelState.IsValid)
            {
                _context.Guides.Add(guide);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guide);
        }
        [HttpGet]
        public IActionResult UpdateGuide(int id)
        {
            var value = _context.Guides.Find(id);
            return value == null ? NotFound() : View(value);
        }
        [HttpPost]
        public IActionResult UpdateGuide(Guide guide)
        {
            if (ModelState.IsValid)
            {
                _context.Guides.Update(guide);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guide);
        }
        [HttpGet]
        public IActionResult DeleteGuide(int id)
        {
            var value = _context.Guides.Find(id);
            return value == null ? NotFound() : View(value);
        }
        [HttpPost]
        public IActionResult DeleteGuide(Guide guide)
        {
            var value = _context.Guides.Find(guide.Id);
            if (value == null)
            {
                return NotFound();
            }
            _context.Guides.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}