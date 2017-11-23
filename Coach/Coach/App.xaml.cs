using Coach.Module.Login;
using Coach.Module.Sync;
using Coach.ViewModels;
using Coach.Views;
using DryIoc;
using Prism.DryIoc;
using Prism.Modularity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Coach
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
        }

        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;

            moduleCatalog.AddModule(
                new ModuleInfo()
                {
                    ModuleName = typeof(LoginModule).Name,
                    ModuleType = typeof(LoginModule),
                }
            );

            moduleCatalog.AddModule(
                new ModuleInfo()
                {
                    ModuleName = typeof(SyncModule).Name,
                    ModuleType = typeof(SyncModule),
                }
            );
        }
    }
}
