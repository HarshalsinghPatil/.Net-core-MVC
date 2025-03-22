using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Controllers
{
    [Route("staff")]
    public class EmployeeController : Controller
    {

        // We can pass data from a controller to a view using:
        //1 ViewBag : ViewBag dynamically stores data that can be used in a View.
        //2 ViewData :ViewData works similarly to ViewBag, but it uses a dictionary.
        //3 TempData : is used for passing data between different requests (useful for redirects).

        //1. ViewBag
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.Message = "Employee List Page";
            return View();
        }


        //2. ViewData

        [Route("list")]
        public IActionResult List()
        {
            ViewData["Message"] = "Welcome to the Employee List Page!";
            return View();
        }

        //3. TempData
        [HttpGet]
        [Route("save")]
        public IActionResult Save()
        {
            TempData["SuccessMessage"] = "Employee record saved successfully!";
            return RedirectToAction("List");
        }


        [Route("create")]
        [HttpPost]
        public IActionResult Create(string name, string department)
        {
            return Content($"Employee Created: {name}, Department: {department}");
        }
    }

}
