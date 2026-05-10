using Microsoft.AspNetCore.Mvc;

namespace ProfileMVC.Controllers;

public class Projects : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}