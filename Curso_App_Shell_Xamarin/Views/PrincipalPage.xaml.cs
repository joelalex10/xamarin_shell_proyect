
using Curso_App_Shell_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit.UI.Views;
namespace Curso_App_Shell_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : ContentPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
            //BindingContext = new PrincipalViewModel();
            

        }
    }
}