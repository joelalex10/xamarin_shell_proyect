using Curso_App_Shell_Xamarin.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Curso_App_Shell_Xamarin.ViewModels
{
    public class MenuItemsViewModel : BaseViewModel
    {
        public Command OnNavigationCommand { get; set; }
        public Command OnNavigationCommandDemo { get; set; }
        public Command OnNavigationCommandPeliculas { get; set; }
        public MenuItemsViewModel()
        {
            OnNavigationCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new SumarPage());
            });
            OnNavigationCommandDemo = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new DemoCountPage());
            });
            OnNavigationCommandPeliculas = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new PeliculasPage());
            });
        }
    }
}
