using CalculatorTest.DataAccessLayer.ADO;
using System.Configuration;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace CalculatorTest.CalculatorApp
{
   public static class DependencyInjector
    {
        private static readonly UnityContainer UnityContainer = new UnityContainer();
        public static void Register<I, T>() where T : I
        {
            UnityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
            UnityContainer.RegisterType <ICalculatorAdo, CalculatorAdo > (new InjectionConstructor(ConfigurationManager.ConnectionStrings["CalculatorConnectionString"].ConnectionString));
        }
        public static void InjectStub<I>(I instance)
        {
            UnityContainer.RegisterInstance(instance, new ContainerControlledLifetimeManager());
        }
        public static T Retrieve<T>()
        {
            return UnityContainer.Resolve<T>();
        }

    }
}
