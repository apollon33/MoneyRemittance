using MoneyRemittance.data.Infrastructure;
using MoneyRemittance.model.Interface;
using StructureMap;

namespace MoneyRemittance.web {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<ICustomerDataSource>().HttpContextScoped().Use<MoneyRemittanceDb>();
                        });
            return ObjectFactory.Container;
        }
    }
}