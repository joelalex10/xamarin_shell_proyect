using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Curso_App_Shell_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("ProductoId", "productoId")]
    public partial class AddProductPage : ContentPage
    {
        private AddProductViewModel addProductViewModel;
        private int productoId;
        public int ProductoId
        {
            get => productoId; set
            {
                productoId = value;
                addProductViewModel = new AddProductViewModel(productoId);
                BindingContext = addProductViewModel;
            }
        }
        public AddProductPage()
        {
            InitializeComponent();
        }
    }
}