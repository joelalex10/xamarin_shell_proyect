using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curso_App_Shell_Xamarin.Models
{
    public class Marca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        [Column("marca_id")]
        public int MarcaId { get; set; }
        [Column("marca_name")]
        public string MarcaName { get; set; }
        [Column("image_url")]
        public string ImageUrl { get; set; }
        [ForeignKey("IdMarca")]
        public List<Product> Products { get; set; }
    }
}