using Route.C41.G02.DAL.Modles;
using System.Collections.Generic;

namespace Route_C41G02.Interface
{
    public interface IDepartmentRepsitory
    {
        

        IEnumerable<Department> GetAll();

        Department Get(int id);
        int Add(Department entity);
        int Update(Department entity);
        int Delete(Department entity);

    }
}
