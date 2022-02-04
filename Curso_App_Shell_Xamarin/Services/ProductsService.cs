using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.Data;
using Curso_App_Shell_Xamarin.DTOs;
using Curso_App_Shell_Xamarin.Models;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;

namespace Curso_App_Shell_Xamarin.Services
{
    public class ProductsService: IProductsService
    {
        private IProductsDBContext DBAccessService => DependencyService.Get<IProductsDBContext>();
        protected ProductsDBContext DbContext => DBAccessService.DbContext;
        
        public async Task<List<ProductoRequest>> GetListProductsDetails()
        {
            List<ProductoRequest> lista =await (from product in DbContext.Products
                    from marca in DbContext.Marcas
                    where product.IdMarca == marca.MarcaId
                    select new ProductoRequest
                    {
                        ProductId = product.ProductId,
                        ProductName = product.ProductName,
                        Description = product.Description,
                        ImageUrl = product.ImageUrl,
                        NombreMarca = marca.MarcaName
                    }).ToListAsync();
            Console.WriteLine($"EL TOTAL DE ELEMENTOS ES: {lista.Count}");
            return lista;
        }

        public Task<Product> GetProduct()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertProduct()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateProduct()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteProduct()
        {
            throw new System.NotImplementedException();
        }
    }
}