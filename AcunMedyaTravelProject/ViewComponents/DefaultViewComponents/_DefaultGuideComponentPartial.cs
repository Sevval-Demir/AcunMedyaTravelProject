using AcunMedyaTravelProject.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaTravelProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultGuideComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultGuideComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var guides = _context.Guides
                .Include(g => g.SocialMedias) 
                .ToList();

            return View(guides); 
        }
    }
}
