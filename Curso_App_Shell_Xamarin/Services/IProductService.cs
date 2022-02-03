using System.Collections.Generic;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.Models;

namespace Curso_App_Shell_Xamarin.Services
{
    public interface IProductService
    {
        Task<List<ProductInfo>> GetProducts();
        Task<ProductInfo> GetProduct(int id);
        Task<bool> AddProduct(ProductInfo productInfo);
        Task<bool> UpdateProduct(ProductInfo productInfo);
        Task<bool> DeleteProduct(int id);
        
    }
}