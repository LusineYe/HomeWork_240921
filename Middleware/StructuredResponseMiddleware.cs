using HomeWork_240921.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace HomeWork_240921.Middleware
{

    public class StructuredResponseMiddleware
    {
        public async Task<Starships> Invoke(HttpContext httpContext)
        {
            HttpClient client = new();
            string URL = "https://swapi.dev/api/starships";
            HttpResponseMessage response = await client.GetAsync(URL);
            string content = await response.Content.ReadAsStringAsync();
            Starships starships = JsonConvert.DeserializeObject<Starships>(content);
            return starships;


        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class StructuredResponseMiddlewareExtensions
    {
        public static IApplicationBuilder UseStructuredResponseMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<StructuredResponseMiddleware>();
        }
    }
}
