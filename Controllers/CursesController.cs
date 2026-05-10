using Microsoft.AspNetCore.Mvc;

namespace ProfileMVC.Controllers;

public class CursesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}