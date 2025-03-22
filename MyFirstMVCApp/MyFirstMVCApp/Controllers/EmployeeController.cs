using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class EmployeeController : Controller
    {

        //Index() is an Action Method that will return a View.
        public IActionResult Index()
        {
            // Passing data through viewbag
            ViewBag.Message = "Hello from EmployeeController!";
            return View();
            //tells the framework to look for a View(in folder Views/Employee/Index) with the same name (Index.cshtml) .
        }




    }
}
