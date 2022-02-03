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
    public partial class SumarPage : ContentPage
    {
        public SumarPage()
        {
            InitializeComponent();
            BindingContext = new SumarViewModel();

            if (EntryValor1.Text == "0")
            {
                EntryValor1.Text = "";
            }
            if (EntryValor2.Text == "0")
            {
                EntryValor2.Text = "";
            }
        }

    }
}