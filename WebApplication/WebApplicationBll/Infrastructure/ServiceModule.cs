using Ninject;
using WebApplicationDal;
using WebApplicationDal.Entities;
using WebApplicationDal.Interfaces;
using WebApplicationDal.Repositories;

namespace WebApplicationBll.Infrastructure
{
    public class ServiceModule
    {
        private static IKernel ninjectKernel;

        public static void InitializeIoC(string connectionString)
        {
            ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IRepository<FirstTable>>().To<FirstTableRepository>();
            ninjectKernel.Bind<IRepository<SecondTable>>().To<SecondTableRepository>();
            ninjectKernel.Bind<IRepository<JoinedTables>>().To<JoinedTablesRepository>().WithConstructorArgument(connectionString);
            ninjectKernel.Bind<IRepository<LogTable>>().To<LogTableRepository>()
                .WithConstructorArgument(connectionString);

        }

        //public static IRepository<FirstTable> FirstTable => ninjectKernel.Get<IRepository<FirstTable>>();

       // public static IRepository<SecondTable> SecondTable => ninjectKernel.Get<IRepository<SecondTable>>();

        public static IRepository<JoinedTables> JoinedTables => ninjectKernel.Get<IRepository<JoinedTables>>();
        public static IRepository<LogTable> LogTable => ninjectKernel.Get<IRepository<LogTable>>();




    }
}