using Curso_App_Shell_Xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Curso_App_Shell_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("PeliculaId", "peliculaId")]
    public partial class AddPeliculaPage : ContentPage
    {
        AddPeliculaViewModel addPeliculaViewModel;
        private int peliculaId;
        public int PeliculaId
        {
            get => peliculaId; set
            {
                peliculaId = value;
                addPeliculaViewModel = new AddPeliculaViewModel(peliculaId);
                BindingContext = addPeliculaViewModel;
            }
        }
        public AddPeliculaPage()
        {
            InitializeComponent();
        }
    }
}