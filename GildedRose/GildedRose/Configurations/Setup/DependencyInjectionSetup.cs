using GildedRose.Application.Interfaces;
using GildedRose.Infra.CrossCuting.IoC;

namespace GildedRose.Configurations.Setup
{
    public static class DependencyInjectionSetup
    {
        public static IGildedRoseService AddDependencyInjectionSetup()
        {
            return DependencyInjector.Instance.GetService<IGildedRoseService>();
        }
    }
}
