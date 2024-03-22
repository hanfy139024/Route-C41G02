using Route.C41.G02.DAL.Modles;
using Route_C41G02.Interface;
using System.Collections.Generic;

namespace Route_C41G02.Repostery
{
    public class DepartmentRepository  : IDepartmentRepsitory
    {
        private ApplictionDbContext _applictionDbContext;
         
         
        public int Add(Department entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(Department entity)
        {
            throw new System.NotImplementedException();
        }
        public int Update(Department entity)
        {
            throw new System.NotImplementedException();
        }

        public Department Get(int id) => _applictionDbContext.Departmant.Find(new { Studentid = 10, CourseId = 1000 });

        public IEnumerable<Department> GetAll()
        {
            throw new System.NotImplementedException();
        }

       
    }
}
