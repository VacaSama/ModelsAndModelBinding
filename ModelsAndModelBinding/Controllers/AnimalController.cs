using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;


namespace ModelsAndModelBinding.Controllers;

public class AnimalController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Animal a)
    {
        // add animal to the database or a collection
        if (ModelState.IsValid)
        {
            // add animal to the collection 
            // redirect to the Animal Index page
            return RedirectToAction("Index");
        }
        // Show webpage with error message 
        return View(a); 
    }

    // I would add to the database here . ~~~~~~~~~~~~~~~~~
    // using (SQLConnection con = new SqlConnection(connectionString)){ 
    //  con.Open(); 
    //  INSERT the information/ parameters needed into the database
    //  con.Close();
}
