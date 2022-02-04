using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curso_App_Shell_Xamarin.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("product_name")]
        public string ProductName { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("image_url")]
        public string ImageUrl { get; set; }
        [Column("marca_id")]
        public int IdMarca { get; set; }
        public virtual Marca Marca { get; set; }
        
    }
}