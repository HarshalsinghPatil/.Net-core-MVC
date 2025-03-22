using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Controllers
{
    [Route("staff")]//Routing for controller
    public class EmployeeController : Controller
    {
        [Route("list")]// staff/list
        public IActionResult List()
        {
            ViewBag.Message = "Employee List Page";
            return View();
        }

        [Route("create")]//staff/create
        [HttpPost]//Post method
        public IActionResult Create(string name, string department)
        {
            return Content($"Employee Created: {name}, Department: {department}");
        }
    }

}
