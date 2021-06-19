using GildedRose.Infra.CrossCuting.IoC;

namespace GildedRose.Configurations.Setup
{
    public static class DependencyInjectionSetup
    {
        public static IGildedRose AddDependencyInjectionSetup()
        {
            return DependencyInjector.Instance.GetService<IGildedRose>();
        }
    }
}
