using Microsoft.AspNetCore.Mvc;

namespace WebServerFinalProj.Controllers;

public class HobbiesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
