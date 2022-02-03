using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Curso_App_Shell_Xamarin.Models;
using Curso_App_Shell_Xamarin.Shared;
using System.Net.Http.Headers;

namespace Curso_App_Shell_Xamarin.Services
{
    public class PeliculaService: IPeliculaService
    {
        private  HttpClient _httpClient = new HttpClient();
        private HttpContent _httpContent;

        public PeliculaService()
        {
            Console.WriteLine("ACCEDIENDO A PELICULAS CHIDAS");
        }
        public async Task<List<Pelicula>> GetPeliculas()
        {
            Console.WriteLine("EL TAMAÑO ES");
            var results = await _httpClient.GetStringAsync($"{Apikey.Uri}Pelicula");
            List<Pelicula> collection = JsonConvert.DeserializeObject<List<Pelicula>>(results);          
            Console.WriteLine(collection.Count);
            return collection;
        }
        public async Task<Pelicula> GetPelicula(int id)
        {
            var results = await _httpClient.GetStringAsync($"{Apikey.Uri}Pelicula/{id}");
            Pelicula pelicula = JsonConvert.DeserializeObject<Pelicula>(results);
            return pelicula;
        }
        public async Task<bool> AddPelicula(Pelicula pelicula) { 
            var json = JsonConvert.SerializeObject(pelicula);
            _httpContent = new StringContent(json);
            _httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await _httpClient.PostAsync($"{Apikey.Uri}Pelicula", _httpContent);
            return result.IsSuccessStatusCode;

        }
        public async Task<bool> UpdatePelicula(Pelicula pelicula, int id) {
            Console.WriteLine($"Pelicula {pelicula}");
            var json = JsonConvert.SerializeObject(pelicula);
            _httpContent = new StringContent(json);
            _httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await _httpClient.PutAsync($"{Apikey.Uri}Pelicula/{id}", _httpContent);
            Console.WriteLine("resultados actualizacion");
            Console.WriteLine(result.ToString());
            return result.IsSuccessStatusCode;
        }
        public async Task<bool> DeletePelicula(int id)
        {
            var result = await _httpClient.DeleteAsync($"{Apikey.Uri}Pelicula/{id}");
            return result.IsSuccessStatusCode;
        }
    }
}
