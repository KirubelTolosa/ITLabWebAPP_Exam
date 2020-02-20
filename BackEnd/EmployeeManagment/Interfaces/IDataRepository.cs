using Employee.DAL;
using System.Collections.Generic;

namespace Employee.DAL.Interfaces
{
    public interface IDataRepository
    {
        
        List<DaDto> GetEmployees();
    }
}
