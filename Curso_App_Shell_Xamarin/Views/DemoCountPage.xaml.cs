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
    public partial class DemoCountPage : ContentPage
    {
        public DemoCountPage()
        {
            InitializeComponent();
            BindingContext = new DemoCountViewModel();
        }
    }
}