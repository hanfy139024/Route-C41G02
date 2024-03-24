using Microsoft.AspNetCore.Mvc;
using Route_C41G02.Interface;
using Route_C41G02.Repostery;

namespace Route_C41G02.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepsitory departmentsRrpo;

        public DepartmentController(IDepartmentRepsitory departmentsRrpo)
        {
            this.departmentsRrpo = departmentsRrpo;
        }

       

        public IActionResult Index()
        {

            return View();
        }
    }
}
