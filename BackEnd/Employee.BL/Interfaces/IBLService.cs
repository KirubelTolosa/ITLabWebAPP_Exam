using Employee.BLL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BLL.Interfaces
{
   public interface IBLService
    {
        
        List<BLDto> GetEmployees();  
    }
}
