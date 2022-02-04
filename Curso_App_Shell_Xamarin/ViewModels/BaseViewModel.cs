using Curso_App_Shell_Xamarin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Curso_App_Shell_Xamarin.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public IPeliculaService PeliculaStore => DependencyService.Get<IPeliculaService>();
        public ICategoriaService CategoriaService => DependencyService.Get<ICategoriaService>();
        public IProductsService ProductoStore => DependencyService.Get<IProductsService>();
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
