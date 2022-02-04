using System.Collections.Generic;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.DTOs;
using Curso_App_Shell_Xamarin.Models;

namespace Curso_App_Shell_Xamarin.Services
{
    public interface IProductsService
    {
        Task<List<ProductoRequest>> GetListProductsDetails();
        Task<Product> GetProduct();
        Task<bool> InsertProduct();
        Task<bool> UpdateProduct();
        Task<bool> DeleteProduct();



    }
}