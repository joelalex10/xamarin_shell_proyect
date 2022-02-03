using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.Models;
using Curso_App_Shell_Xamarin.Shared;

namespace Curso_App_Shell_Xamarin.Services
{
    public class CategoriaService: ICategoriaService
    {
        private HttpClient _httpClient = new HttpClient();
        public async Task<List<Categoria>> GetCategorias()
        {
            var results = await _httpClient.GetStringAsync($"{Apikey.Uri}Categoria");
            List<Categoria> collection = JsonConvert.DeserializeObject<List<Categoria>>(results);
            Console.WriteLine($"EL ARREGLO ES: {collection.Count}");
            //ListPeliculas = new ObservableCollection<Pelicula>(collection);
            return collection;
        }
    }
}
