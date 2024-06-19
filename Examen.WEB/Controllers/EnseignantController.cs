using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.WEB.Controllers
{
    public class EnseignantController : Controller
    {

        IserviceEnseignant sp;
        IserviceCandidature tp;

        public EnseignantController(IserviceEnseignant sp, IserviceCandidature tp)
        {
            this.sp = sp;
            this.tp = tp;
        }



        // GET: EnseignantController Concours
        public ActionResult Index(string? ups)
        {
            if(ups==null )
            return View(sp.GetAll());
           
            return View(sp.GetMany(p=>p.UPFK.Equals(ups) ));
             

        }
        public ActionResult candidature(string? ups)
        {
            if (ups == null)
                return View(sp.GetAll());

            return View(sp.GetMany(p => p.UPFK.Equals(ups)));


        }

        // GET: EnseignantController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnseignantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnseignantController/Create
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

        // GET: EnseignantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnseignantController/Edit/5
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

        // GET: EnseignantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnseignantController/Delete/5
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
