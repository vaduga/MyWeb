using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers;

public class CategoryController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}