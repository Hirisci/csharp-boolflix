using AspNetCoreHero.ToastNotification.Abstractions;
using csharp_boolflix.Data;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Security.Cryptography;

namespace csharp_boolflix.Controllers
{
    public class FeatureController : Controller
    {
        private readonly BoolflixContext _db;
        private readonly INotyfService _toastNotification;

        public FeatureController(BoolflixContext db, INotyfService toastNotification)
        {
            _db = db;
            _toastNotification = toastNotification;
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
            var isDouble = _db.Features.ToList().FirstOrDefault(x => x.Name == feature.Name);
            if (isDouble == null)
            {
                _toastNotification.Warning("Attenzione "+ feature.Name +" giá prensente in Database");
                return View(feature);
            }


            _db.Features.Add(feature);
            _db.SaveChanges();
            _toastNotification.Success(feature.Name + "é stato creato con successo!");
            return RedirectToAction("Features", "Editor");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var feature = _db.Features.FirstOrDefault(x => x.Id == id);
            if (feature == null)
            {
                _toastNotification.Error("Impossibile Cancellare");
                return RedirectToAction("Features", "Editor");
            }

            _toastNotification.Success(feature.Name + "  stato cancellato con successo!");
            _db.Features.Remove(feature);
            _db.SaveChanges();
            return RedirectToAction("Features", "Editor");
        }

        //_toastNotification.Success("A success for christian-schou.dk");
        //_toastNotification.Information("Here is an info toast - closes in 6 seconds.", 6);
        //_toastNotification.Warning("Be aware, here is a warning toast.");
        //_toastNotification.Error("Ouch - An error occured. This message closes in 4 seconds.", 4); 
    }
}
