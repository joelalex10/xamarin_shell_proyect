using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.Models;
using Xamarin.Forms;

namespace Curso_App_Shell_Xamarin.ViewModels
{
    public class ProductsViewModel:BaseViewModel
    {
        public Command LoadProductsCommand { get; }
        public ObservableCollection<ProductInfo> ListProductInfos
        {
            get => listProductInfos;
            set
            {
                listProductInfos = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<ProductInfo> listProductInfos;

        public ProductsViewModel()
        {
            ListProductInfos = new ObservableCollection<ProductInfo>();
            LoadProductsCommand = new Command(async () => await ExecuteLoadProductsCommand());
        }
        public async Task ExecuteLoadProductsCommand()
        {
            Console.WriteLine(" EJECUTANDO ExecuteLoadProductsCommand");
            IsBusy = true;
            try
            {
                ListProductInfos.Clear();
                Console.WriteLine("ACCEDIENDO A TRY CATCH");
                var productInfos = await ProductStore.GetProducts();
                foreach (var item in productInfos)
                {
                    ListProductInfos.Add(item);
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("HA OCURRIDO UN ERROR");
                Console.WriteLine(ex);
                Console.WriteLine("RESULTADOS");
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            Console.WriteLine("VIEW MODEL PRODUCTOS");
            IsBusy = true;
        }
        
    }
}