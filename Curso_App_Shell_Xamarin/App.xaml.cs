using Curso_App_Shell_Xamarin.Services;
using Curso_App_Shell_Xamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Curso_App_Shell_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<PeliculaService>();
            DependencyService.Register<CategoriaService>();
            DependencyService.Register<ProductService>();
            //MainPage =new NavigationPage(new MenuItemsPage());
            MainPage = new AppShell();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
