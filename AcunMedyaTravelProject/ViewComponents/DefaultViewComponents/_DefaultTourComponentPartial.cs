using AcunMedyaTravelProject.Context;
using Microsoft.AspNetCore.Mvc;
using AcunMedyaTravelProject.Entities;
using AcunMedyaTravelProject.Models;

namespace AcunMedyaTravelProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultTourComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;
        public _DefaultTourComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var nationalTours=_context.Tours.ToList();
            var countries = _context.Countries.ToList();
            var model = new TourViewModel
            {
                Countries = countries,
                Tours = nationalTours
            };
            return View(model);
        }
    }
}
