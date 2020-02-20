using Autofac;
using Employee.DAL;
using Employee.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL
{
    public class DIModule
    {
        public static void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<DataRepository>().As<IDataRepository>();
        }
    }
}
