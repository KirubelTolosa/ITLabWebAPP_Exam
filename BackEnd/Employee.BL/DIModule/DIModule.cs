using Autofac;
using Employee.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BLL
{
    public  class DIModule
    {
        public static void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<BLService>().As<IBLService>();
            DAL.DIModule.RegisterServices(builder);
        }
    }
}
