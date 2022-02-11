using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Data;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class DapperTestController : Controller
    {
        ICategoryRepository repo;
        public DapperTestController(ICategoryRepository r)
        {
            repo = r;
        }
        public ActionResult Index()
        {
            return View(repo.GetCategories());
        }
 
        public ActionResult Details(int id)
        {
            Category category = repo.Get(id);
            if (category != null)
                return View(category);
            return NotFound();
        }
 
        public ActionResult Create()
        {
            return View();
        }
 
        [HttpPost]
        public ActionResult Create(Category category)
        {
            repo.Create(category);
            return RedirectToAction("Index");
        }
 
        public ActionResult Edit(int id)
        {
            Category category = repo.Get(id);
            if (category != null)
                return View(category);
            return NotFound();
        }
 
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            repo.Update(category);
            return RedirectToAction("Index");
        }
 
        [HttpGet]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            Category category = repo.Get(id);
            if (category != null)
                return View(category);
            return NotFound();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}