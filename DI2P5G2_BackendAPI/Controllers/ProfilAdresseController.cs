using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DI2P5G2_BackendAPI.Controllers
{
    public class ProfilAdresseController : Controller
    {
        // GET: ProfilAdresseController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProfilAdresseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfilAdresseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfilAdresseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfilAdresseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfilAdresseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfilAdresseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfilAdresseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
