using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_App_Shell_Xamarin.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Director { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public override string ToString()
        {
            return $"Id: {this.Id}\n" +
                $"Nombre: {this.Nombre}\n" +
                $"Director: {this.Director}\n+" +
                $"Categoria Id: {this.CategoriaId}";
        }
    }
}
