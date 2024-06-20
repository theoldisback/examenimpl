using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Web.Controllers
{
    public class ColisController : Controller
    {

        IServiceColis sc;
        IServiceClient sclie;
        IServiceLivreur sl;

        public ColisController(IServiceColis sc,
        IServiceClient sclie,
        IServiceLivreur sl)
        {
            this.sc = sc;
            this.sclie = sclie;
            this.sl = sl;
        }

        // GET: ColisController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ColisController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ColisController/Create
        public ActionResult Create()
        {
            ViewBag.liv = new SelectList(sl.GetMany(), "ClientFK", "Information");
            ViewBag.cli = new SelectList(sclie.GetMany(), "LivreurFK", "Information");
            return View();
        }

        // POST: ColisController/Create
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

        // GET: ColisController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ColisController/Edit/5
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

        // GET: ColisController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ColisController/Delete/5
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
