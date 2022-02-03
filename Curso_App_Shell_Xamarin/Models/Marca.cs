using SQLite;

namespace Curso_App_Shell_Xamarin.Models
{
    public class Marca
    {
        [PrimaryKey,AutoIncrement, Column("marca_id")]
        public int MarcaId { get; set; }
        [Column("marca_name")]
        public string MarcaName { get; set; }
        [Column("image_url")]
        public string ImageUrl { get; set; }

        public Marca()
        {
        }

        public Marca(int marcaId, string marcaName, string imageUrl)
        {
            MarcaId = marcaId;
            MarcaName = marcaName;
            ImageUrl = imageUrl;
        }
    }
}