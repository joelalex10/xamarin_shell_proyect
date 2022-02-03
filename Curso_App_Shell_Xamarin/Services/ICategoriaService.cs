using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.Models;

namespace Curso_App_Shell_Xamarin.Services
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> GetCategorias();

    }
}
