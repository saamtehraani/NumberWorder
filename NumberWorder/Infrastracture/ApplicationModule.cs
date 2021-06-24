using Autofac;
using NumberWorder.Abstract;
using NumberWorder.Services;

namespace NumberWorder.Infrastracture
{
    public class ApplicationModule : Module
    {
        public ApplicationModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            #region Services
            builder.RegisterType<EntryPoint>();
            builder.RegisterType<MapNumberService>().As<IMapNumberService>().InstancePerLifetimeScope();
            builder.RegisterType<DigitSeperatorService>().As<IDigitSeperatorService>().InstancePerLifetimeScope();
            #endregion
        }
    }
}
