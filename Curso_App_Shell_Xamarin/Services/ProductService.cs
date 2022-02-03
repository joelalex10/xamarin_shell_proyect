using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.Models;
using SQLite;

namespace Curso_App_Shell_Xamarin.Services
{
    public class ProductService:IProductService
    {
        private SQLiteAsyncConnection _database;

        public ProductService()
        {
            var dbName = "products.db3";
            _database = new SQLiteAsyncConnection(dbName);
            _database.CreateTableAsync<ProductInfo>().Wait();
            _database.CreateTableAsync<Marca>().Wait();
            
            Console.WriteLine("EL NOMBRE DEL ARCHIVO ES");
            Console.WriteLine(dbName);
            Console.WriteLine("SE CREARAN LOS ARCHIVOS");
        }

        public async Task<List<ProductInfo>> GetProducts()
        {
            Console.WriteLine("se obtendran los productos");
            // var query = from product in _database.Table<ProductInfo>() 
            //     from marca in _database.Table<Marca>()
            //     select new ProductInfo{};
            return await Task.FromResult(await _database.Table<ProductInfo>().ToListAsync());
        }

        public async Task<ProductInfo> GetProduct(int id)
        {
            return await Task.FromResult(await _database.Table<ProductInfo>().Where(
                p => p.ProductId== id).FirstOrDefaultAsync());
        }

        public async Task<bool> AddProduct(ProductInfo productInfo)
        {
            var results = await _database.InsertAsync(productInfo);
            return await Task.FromResult(true);

        }

        public async Task<bool> UpdateProduct(ProductInfo productInfo)
        {
            var results = await _database.UpdateAsync(productInfo);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteProduct(int id)
        {
            await _database.DeleteAsync<ProductInfo>(id);
            return await Task.FromResult(true);
        }
    }
}