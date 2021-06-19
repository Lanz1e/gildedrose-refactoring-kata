using GildedRose.Application.Interfaces;
using GildedRose.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GildedRose.Infra.CrossCuting.IoC
{
    public class DependencyInjector
    {
        public IServiceProvider ServiceProvider { get; set; }

        private static readonly Lazy<DependencyInjector>
        lazy =
        new Lazy<DependencyInjector>
            (() => new DependencyInjector());

        public static DependencyInjector Instance { get { return lazy.Value; } }

        private DependencyInjector()
        {
            ServiceProvider = GetServiceProvider();
        }

        public T GetService<T>()
        {
            return ServiceProvider.GetService<T>();
        }
        private static IServiceProvider GetServiceProvider()
        {
            return new ServiceCollection()
                .AddTransient<IGildedRoseService, GildedRoseService>()
                .BuildServiceProvider();
        }
    }
}
