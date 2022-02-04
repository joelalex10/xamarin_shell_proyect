using System;

namespace Curso_App_Shell_Xamarin.ViewModels
{
    public class AddProductViewModel:BaseViewModel
    {
        public int productId { get; set; }
        public AddProductViewModel(int productId)
        {
            this.productId = productId;
            Console.WriteLine($"EL ID ES: {this.productId}");
        }
    }
}