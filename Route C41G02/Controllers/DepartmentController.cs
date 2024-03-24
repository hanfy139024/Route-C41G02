using Microsoft.AspNetCore.Mvc;

namespace Route_C41G02.Controllers
{
    public class DepartmentController : Controller
    {
        private DepartmentRepostory() { }
        public IActionResult Index()
        {
            return View();
        }
    }
}
