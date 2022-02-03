using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_App_Shell_Xamarin.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}\n" +
                $"Nombre: {this.Nombre}\n"+
                $"Estado: {this.Estado}\n";
        }

    }
}
