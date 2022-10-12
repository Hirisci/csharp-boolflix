using csharp_boolflix.Data;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class EditorController : Controller
    {
        private readonly BoolflixContext _db;

        public EditorController(BoolflixContext db) {
                _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Movies()
        {
            return View();
        }
        public IActionResult TvSeries()
        {
            return View();
        }
        public IActionResult Genres()
        {
            List<Genre> Genre = _db.Genres.ToList();
            return View(Genre);
            
        }

        public IActionResult Features()
        {
            List<Feature> features = _db.Features.ToList();
            return View(features);
        }


        public IActionResult Actors()
        {
            return View();
        }
    }
}
