using Employee.BLL.DataModel;
using Employee.BLL.Interfaces;
using Employee.DAL;
using Employee.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BLL
{
    class BLService : IBLService
    {
        private IDataRepository dataRepository;
        public BLService()
        {
            this.dataRepository = new DataRepository();
        }
        public BLService(IDataRepository DataRepository)
        {
            dataRepository = DataRepository; 
        }
        
        public List<BLDto> GetEmployees()
        {
            List<BLDto> employeesBLDtos = new List<BLDto>();
            List<DaDto> employeesDaDtos = dataRepository.GetEmployees();
            foreach(var employee in employeesDaDtos)
            {
                BLDto employeeBldto = new BLDto
                {
                   
                    userName = employee.userName,
                    password = employee.password,                    
                };
                employeesBLDtos.Add(employeeBldto);
            }
            return employeesBLDtos;
        }
    }
}
