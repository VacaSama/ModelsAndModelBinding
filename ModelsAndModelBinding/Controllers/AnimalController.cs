using Microsoft.AspNetCore.Mvc;

namespace ModelsAndModelBinding.Controllers;

public class AnimalController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
}
