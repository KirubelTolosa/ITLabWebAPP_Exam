using Employee.BLL.Interfaces;
using Employee.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Employee.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CredentialsController : ApiController
    {        
        private IBLService bLService;
        public CredentialsController(IBLService bLService)
        {
            this.bLService = bLService;
        }
        public List<EmployeeModel> Get()
        {
            return bLService.GetEmployees().Select(x => new EmployeeModel() { userName = x.userName, password = x.password}).ToList();
        }
           
    }
}
