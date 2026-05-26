using Microsoft.AspNetCore.Mvc;

namespace ProfileMVC.Controllers;

public class ContactController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}