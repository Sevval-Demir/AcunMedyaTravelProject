using AcunMedyaTravelProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaTravelProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultFooterComponentPartial :ViewComponent
    {
        private readonly AppDbContext _context;
        public _DefaultFooterComponentPartial(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var value = _context.Footers.FirstOrDefault();
            return View(value);
        }

    }
}
