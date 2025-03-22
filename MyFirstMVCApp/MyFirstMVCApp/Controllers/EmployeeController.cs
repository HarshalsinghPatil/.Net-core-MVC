using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // Before of https://localhost:[port]/Employee/Index.
        //Now, https://localhost:[port]/staff/list will show the Employee page 
        [Route("staff/list")]
        public IActionResult Index()
        {
            
            ViewBag.Message = "Employees list";
            return View();
            
        }




    }
}
