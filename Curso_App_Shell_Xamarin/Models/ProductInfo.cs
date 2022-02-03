using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Curso_App_Shell_Xamarin.Models
{
    public class ProductInfo
    {
        [PrimaryKey,AutoIncrement, Column("product_id")]
        public int ProductId { get; set; }
        [Column("product_name")]
        public string ProductName { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("image_url")]
        public string ImageUrl { get; set; }
        [ForeignKey(typeof(Marca))]
        public int IdMarca { get; set; }

        public ProductInfo()
        {
            
        }

        public ProductInfo(int productId, string productName, string description, string imageUrl, int idMarca)
        {
            ProductId = productId;
            ProductName = productName;
            Description = description;
            ImageUrl = imageUrl;
            IdMarca = idMarca;
        }
    }
}