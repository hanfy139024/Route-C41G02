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
        //

        public IActionResult Detaills(int? id)
        {
            if (!id.HasValue)
                return BadRequest(); // 400
            var department= this.departmentsRrpo.Get(id.Value);
                
            if (department is null)
                return NotFound(); // 404
            return View(department);

        }




    }
}
