using Microsoft.AspNetCore.Mvc;

namespace OldSoftware.Presentation.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}