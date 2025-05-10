using Microsoft.AspNetCore.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaTravelProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController : Controller
    {
        private readonly AppDbContext _context;

        public SocialMediaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.SocialMedias.Include(x => x.Guide).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            ViewBag.Guides = _context.Guides.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                _context.SocialMedias.Add(socialMedia);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Guides = _context.Guides.ToList();
            return View(socialMedia);
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = _context.SocialMedias.Find(id);
            if (value == null) return NotFound();

            ViewBag.Guides = _context.Guides.ToList();
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                _context.SocialMedias.Update(socialMedia);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Guides = _context.Guides.ToList();
            return View(socialMedia);
        }

        [HttpGet]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _context.SocialMedias.Find(id);
            if (value == null) return NotFound();

            return View(value);
        }

        [HttpPost]
        public IActionResult DeleteSocialMedia(SocialMedia socialMedia)
        {
            var value = _context.SocialMedias.Find(socialMedia.Id);
            if (value == null) return NotFound();

            _context.SocialMedias.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
