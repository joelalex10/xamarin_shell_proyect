using Curso_App_Shell_Xamarin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Curso_App_Shell_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
            RegisterRoutes();

        }
        //protected override async void OnNavigated(ShellNavigatedEventArgs args)
        //{
        //    base.OnNavigated(args);
        //    //string source = args.Source!=null?args.Source.ToString():"";
        //    //string previous = args.Previous != null ? args.Previous.Location.ToString() : "";
        //    //string current = args.Current != null ? args.Current.Location.ToString() : "";
        //    //string mensaje = $"Se realizo {source} desde {previous} hacia {current}";

        //    //await DisplayAlert("Navegacion", mensaje, "OK");
        //}
        public ICommand LuckyCommand => new Command(async () =>
        {
            //await Shell.Current.GoToAsync("//Principal");
            Console.WriteLine("ACCESO A METODO");
            //await Shell.Current.GoToAsync($"AddPeliculaPage?id={}");
        });

        public void RegisterRoutes() {
            Routing.RegisterRoute(nameof(AddPeliculaPage), typeof(AddPeliculaPage));
        }
    }
}