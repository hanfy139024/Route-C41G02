using Route.C41.G02.DAL.Modles;
using Route_C41G02.Interface;
using System.Collections.Generic;


namespace Route_C41G02.Repostery
{
    public class DepartmentRepository  : IDepartmentRepsitory
    {
        private Route.C41.G02.DAL.Data.ApplictionDbContext _applictionDbContext;

        public DepartmentRepository(Route.C41.G02.DAL.Data.ApplictionDbContext applictionDbContext )
        {
            _applictionDbContext = applictionDbContext;
            
        }


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

        public Department Get(int id) => _applictionDbContext.Department.Find(new {Student=100 ,Id=20});

        public IEnumerable<Department> GetAll()
        {
            throw new System.NotImplementedException();
        }

       
    }
}
