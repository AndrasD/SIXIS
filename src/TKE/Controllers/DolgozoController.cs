using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using TKE.Models;
using TKE.Services;
using TKE.ViewModels.Dolgozo;


namespace TKE.Controllers
{
    public class DolgozoController : Controller
    {
        private ApplicationDbContext _context;

        public DolgozoController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Dolgozo
        public IActionResult Index()
        {
            return View(_context.Dolgozo.ToList());
        }

        // GET: Dolgozo/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Dolgozo dolgozo = _context.Dolgozo.Single(m => m.DolgozoID == id);
            if (dolgozo == null)
            {
                return HttpNotFound();
            }

            return View(dolgozo);
        }

        // GET: Dolgozo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dolgozo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Dolgozo dolgozo)
        {
            if (ModelState.IsValid)
            {
                _context.Dolgozo.Add(dolgozo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dolgozo);
        }

        // GET: Dolgozo/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Dolgozo dolgozo = _context.Dolgozo.Single(m => m.DolgozoID == id);
            if (dolgozo == null)
            {
                return HttpNotFound();
            }
            return View(dolgozo);
        }

        // POST: Dolgozo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Dolgozo dolgozo)
        {
            if (ModelState.IsValid)
            {
                _context.Update(dolgozo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dolgozo);
        }

        // GET: Dolgozo/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Dolgozo dolgozo = _context.Dolgozo.Single(m => m.DolgozoID == id);
            if (dolgozo == null)
            {
                return HttpNotFound();
            }

            return View(dolgozo);
        }

        // POST: Dolgozo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Dolgozo dolgozo = _context.Dolgozo.Single(m => m.DolgozoID == id);
            _context.Dolgozo.Remove(dolgozo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
