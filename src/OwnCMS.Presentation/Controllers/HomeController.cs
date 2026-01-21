using Microsoft.AspNetCore.Mvc;

namespace OwnCMS.Presentation.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
}