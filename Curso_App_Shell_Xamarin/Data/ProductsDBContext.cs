using System;
using System.IO;
using Curso_App_Shell_Xamarin.Models;
using Curso_App_Shell_Xamarin.Shared;
using Microsoft.EntityFrameworkCore;
using Xamarin.Essentials;

namespace Curso_App_Shell_Xamarin.Data
{
    public class ProductsDBContext:DbContext, IProductsDBContext
    {
        private ProductsDBContext _dbContext;

        ProductsDBContext IProductsDBContext.DbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new ProductsDBContext();
                    SQLitePCL.Batteries_V2.Init();
                    _dbContext.Database.EnsureCreated();
                }

                return _dbContext;
            }
        }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Product> Products { get; set; }

        // public ProductsDBContext()
        // {
        //     SQLitePCL.Batteries_V2.Init();
        //     this.Database.EnsureCreated();
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, DatabaseName.FileName);
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}