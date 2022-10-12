using csharp_boolflix.Data;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class FeatureController : Controller
    {
        private readonly BoolflixContext _db;

        public FeatureController(BoolflixContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Feature feature)
        {
            if (!ModelState.IsValid)
            {
                return View(feature);
            }

            _db.Features.Add(feature);
            _db.SaveChanges();

            return RedirectToAction("Feature","Editor");
        }
    }
}
