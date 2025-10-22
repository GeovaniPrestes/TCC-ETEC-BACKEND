using Autofac;
using BackEnd.Aritmica.Connection;
using BackEnd.Aritmica.Connection.Interfaces;
using BackEnd.Aritmica.Data;

namespace BackEnd.Aritmica.DependencyInjection
{
    public class WholeSystemModulesWithoutLoadingDataInjection : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            try
            {

                containerBuilder.RegisterType<ConnectionFactory>().As<IConnectionFactory>();
            }
            catch (Exception exception)
            {
                // ignored
            }
        }
    }
}
