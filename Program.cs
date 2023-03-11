using RestSharp;
using System.Text.Json;
using Flurl.Http;

namespace APIConsume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //httpclient
            //using (var client = new HttpClient())
            //{
            //    var request = new HttpRequestMessage(HttpMethod.Get, "https://api.themoviedb.org/3/movie/popular?api_key=837fd3c1b9dffbbe7b69a4a979ab2fe3&language=en-US&page=1");
            //    var response = client.SendAsync(request).Result;
            //    string json = response.Content.ReadAsStringAsync().Result;

            //    //var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = false };
            //    var sonuc = JsonSerializer.Deserialize<MovieList>(json);

            //    foreach (var film in sonuc.results)
            //    {
            //        Console.WriteLine(film.title);
            //    }
            //}

            //restsharp

            //using (var client = new RestClient())
            //{
            //    var request = new RestRequest("https://api.themoviedb.org/3/movie/popular?api_key=837fd3c1b9dffbbe7b69a4a979ab2fe3&language=en-US&page=1", Method.Get);
            //    var result = client.Get<MovieList>(request);

            //    foreach (var film in result.results)
            //    {
            //        Console.WriteLine(film.title);
            //    }
            //}

            //flurl

            var sonuc = "https://api.themoviedb.org/3/movie/popular?api_key=837fd3c1b9dffbbe7b69a4a979ab2fe3"
                .GetJsonAsync<MovieList>().Result;

            foreach (var film in sonuc.results)
            {
                Console.WriteLine(film.title);
            }

            Console.Read();
        }
    }
}