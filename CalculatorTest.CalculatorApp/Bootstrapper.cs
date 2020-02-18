using CalculatorTest.DataAccessLayer.Repository;

namespace CalculatorTest.CalculatorApp
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<ICalculatorRepository, CalculatorRepository>();
        }
    }
}
