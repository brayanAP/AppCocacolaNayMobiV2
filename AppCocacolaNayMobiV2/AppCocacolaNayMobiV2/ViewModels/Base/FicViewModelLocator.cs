using Autofac;
using AppCocacolaNayMobiV2.Services.Navigation;
using AppCocacolaNayMobiV2.Services.Inventarios;
using AppCocacolaNayMobiV2.Interfaces.Navigation;
using AppCocacolaNayMobiV2.Interfaces.Inventarios;
using AppCocacolaNayMobiV2.ViewModels.Inventarios;

namespace AppCocacolaNayMobiV2.ViewModels.Base
{
    public class FicViewModelLocator
    {
        private static IContainer FicContainer;

        public FicViewModelLocator()
        {
            var builder = new ContainerBuilder();

            // ViewModels
            builder.RegisterType<FicVmConteoInventarioList>();
            builder.RegisterType<FicVmConteoInventarioItem>();
            //builder.RegisterType<FicListVmInventario>();

            // Services
            builder.RegisterType<FicSrvNavigationInventario>().As<IFicSrvNavigationInventario>().SingleInstance();
            builder.RegisterType<FicSrvConteoInventarioList>().As<IFicSrvConteoInventario>();

            if (FicContainer != null)
            {
                FicContainer.Dispose();
            }

            FicContainer = builder.Build();
        }
        /*public FicListVmInventario FicLiVmInventario
        {
            get { return FicContainer.Resolve<FicListVmInventario>(); }
        }*/

        //FIC: se manda llamar desde el backend de la View de List
        public FicVmConteoInventarioList FicVmConteoInventarioList
        {
            get { return FicContainer.Resolve<FicVmConteoInventarioList>(); }
        }

        //FIC: se manda llamar desde el backend de la View de Item
        public FicVmConteoInventarioItem FicVmConteoInventarioItem
        {
            get { return FicContainer.Resolve<FicVmConteoInventarioItem>(); }
        }
    }
}
