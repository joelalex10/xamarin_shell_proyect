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
    public partial class ProductsPage : ContentPage
    {
        private ProductsViewModel _productsViewModel;
        public ProductsPage()
        {
            InitializeComponent();
            BindingContext = _productsViewModel = new ProductsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _productsViewModel.OnAppearing();
        }
    }
}