using Curso_App_Shell_Xamarin.Services;
using Curso_App_Shell_Xamarin.Views;
using System;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.Data;
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
            DependencyService.Register<ProductsService>();
            DependencyService.Register<IProductsDBContext, ProductsDBContext>();
            //GetContext().Database.EnsureCreated();
            MainPage = new AppShell();

        }
        // public static ProductsDBContext GetContext()
        // {
        //     return new ProductsDBContext();
        // }


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
