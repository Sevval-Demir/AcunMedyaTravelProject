using AcunMedyaTravelProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaTravelProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;
        public _DefaultTestimonialComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Testimonials.ToList(); 
            return View(values);
        }
    }
}
