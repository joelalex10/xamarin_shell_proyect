using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.Models;

namespace Curso_App_Shell_Xamarin.Services
{
    public interface IPeliculaService
    {
        Task<List<Pelicula>> GetPeliculas();
        Task<bool> AddPelicula(Pelicula pelicula);
        Task<Pelicula> GetPelicula(int id);
        Task<bool> UpdatePelicula(Pelicula pelicula, int id);
        Task<bool> DeletePelicula(int id);
    }
}
