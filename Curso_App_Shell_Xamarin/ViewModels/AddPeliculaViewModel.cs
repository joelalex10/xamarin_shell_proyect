using Curso_App_Shell_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Curso_App_Shell_Xamarin.ViewModels
{
    public class AddPeliculaViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public String PeliculaEntry
        {
            get => _peliculaEntry;
            set
            {
                _peliculaEntry = value;
                OnPropertyChanged();
            }
        }
        private string _peliculaEntry;
        public String DirectorEntry { get => _directorEntry; 
            set {
                _directorEntry = value;
                OnPropertyChanged();
            } 
        }
        private string _directorEntry;
        public Categoria SelectedCategoria
        {
            get => _selectedCategoria; set
            {
                _selectedCategoria = value;
                OnPropertyChanged();
            }
        }
        private Categoria _selectedCategoria;
        public Command AgregarCommand { get; set; }

        private ObservableCollection<Categoria> categoriasList;
        public ObservableCollection<Categoria> CategoriasList
        {
            get => categoriasList;
            set
            {
                categoriasList = value;
                OnPropertyChanged();
            }
        }
        private List<Categoria> _Categorias { get; set; }
        public int peliculaId { get; set; }
        public AddPeliculaViewModel(int _peliculaId)
        {
            this.peliculaId = _peliculaId;
            _Categorias = new List<Categoria>();
            CategoriasList = new ObservableCollection<Categoria>();
            if (this.peliculaId != 0)
            {
                Title = "Actualizar";
                Console.WriteLine("SE ACTUALIZARA DATO");
                GetPelicula();
            }
            else
            {
                Title = "Agregar";
                GetAllCategories();
                Console.WriteLine("SE AGREGARA DATO");
            }

            AgregarCommand = new Command(async () =>
            {
                await AgregarPelicula();
            });
        }

        private async Task AgregarPelicula()
        {
            if (PeliculaEntry != null && DirectorEntry != null && SelectedCategoria != null)
            {
                Console.WriteLine($"LA PELICULA ES: {PeliculaEntry}");
                Console.WriteLine($"EL DIRECTOR ES: {DirectorEntry}");
                Console.WriteLine($"LA CATEGORIA ES: {SelectedCategoria.Id}");
                Pelicula NewPelicula = new Pelicula()
                {
                    Nombre = PeliculaEntry,
                    Director = DirectorEntry,
                    CategoriaId = SelectedCategoria.Id
                };
                if (this.peliculaId == 0){
                    bool result = await PeliculaStore.AddPelicula(NewPelicula);
                    if (result)
                    {
                        await App.Current.MainPage.DisplayAlert("Exito", "Se agrego la pelicula correctamente", "OK");
                        //await Application.Current.MainPage.Navigation.PopToRootAsync();
                        await Shell.Current.GoToAsync("//Peliculas");
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Error", "No se pudo agregar la pelicula", "OK");
                    }
                }
                else {
                    NewPelicula.Id = this.peliculaId;
                    bool result = await PeliculaStore.UpdatePelicula(NewPelicula,this.peliculaId);
                    if (result)
                    {
                        await App.Current.MainPage.DisplayAlert("Exito", "Se actualizo la pelicula correctamente", "OK");
                        await Shell.Current.GoToAsync("//Peliculas");
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Error", "No se pudo actualizar la pelicula", "OK");
                    }

                }
            }
            else
            {
                Console.WriteLine("HA OCURRIDO UN ERROR");
                await App.Current.MainPage.DisplayAlert("Error", "Debe llenar todos los campos", "OK");
            }
        }

        public async void GetPelicula()
        {
            await GetAllCategories();
            var pelicula = await PeliculaStore.GetPelicula(this.peliculaId);
            Console.WriteLine("\nPELICULA A ACTUALIZAR");
            Console.WriteLine(pelicula);
            PeliculaEntry = pelicula.Nombre;
            DirectorEntry = pelicula.Director;

            foreach (var categoria in _Categorias)
            {
                if(categoria.Id== pelicula.CategoriaId)
                {
                    SelectedCategoria = categoria;
                }
            }
        }
        public async Task GetAllCategories()
        {
            Console.WriteLine("LISTA DE CATEGORIAS");
            _Categorias = await CategoriaService.GetCategorias();

            foreach (var categoria in _Categorias)
            {
                CategoriasList.Add(categoria);
            }
            //SelectedCategoria = Categorias[1];
            //Console.WriteLine($"EL OBJETO ES {SelectedCategoria}");
            Console.Write($"EL TAMAÑO DE LA LISTA ES {_Categorias.Count}");
        }
    }
}
