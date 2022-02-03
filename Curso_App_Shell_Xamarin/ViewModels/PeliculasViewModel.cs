using Curso_App_Shell_Xamarin.Models;
using Curso_App_Shell_Xamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Curso_App_Shell_Xamarin.ViewModels
{
    public class PeliculasViewModel: BaseViewModel
    {
        public Command LoadPeliculasCommand { get; }
        public Command AgregarCommand { get; set; }
        public Command<Pelicula> UpdateCommand { get; }
        public Command<Pelicula> DeleteCommand { get; set; }
        public ObservableCollection<Pelicula> ListPeliculas
        {
            get => listPeliculas;
            set
            {
                listPeliculas = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Pelicula> listPeliculas;

        public PeliculasViewModel()
        {
            LoadPeliculasCommand = new Command(async () => await ExecuteLoadPeliculasCommand());
            UpdateCommand = new Command<Pelicula>(ExecuteUpdateCommand);
            DeleteCommand = new Command<Pelicula>(ExecuteDeleteCommand);
            AgregarCommand = new Command(async () => await ExecuteAgregarCommand());
            ListPeliculas = new ObservableCollection<Pelicula>();
        }
        public async void ExecuteDeleteCommand(Pelicula pelicula)
        {
            bool result = await PeliculaStore.DeletePelicula(pelicula.Id);
            if (result)
            {
                await App.Current.MainPage.DisplayAlert("Exito", "Se elimino la pelicula correctamente", "OK");
                ListPeliculas.Remove(pelicula);
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "No se pudo actualizar la pelicula", "OK");
            }
        }
        public async Task ExecuteAgregarCommand()
        {
            await Shell.Current.GoToAsync($"AddPeliculaPage?peliculaId={0}");
        }
        public async void ExecuteUpdateCommand(Pelicula pelicula)
        {
            await Shell.Current.GoToAsync($"AddPeliculaPage?peliculaId={pelicula.Id}");
        }
        public async Task ExecuteLoadPeliculasCommand() {
            IsBusy = true;
            try
            {
                ListPeliculas.Clear();
                var peliculas = await PeliculaStore.GetPeliculas();
                foreach (var item in peliculas)
                {
                    ListPeliculas.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        public async void GetPeliculas()
        {
            var Peliculas = await PeliculaStore.GetPeliculas();
            foreach (var pelicula in Peliculas)
            {
                ListPeliculas.Add(pelicula);
            }
        }
        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
