using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Hotel_Mobile
{
    internal class Program
    {
        const string ID_HOST = "http://localhost:57186";
        const string HOST_API = "http://localhost:54547";
        static async void Main(string[] args)
        {
            Console.WriteLine("Test The APIs in Mobile");
            Console.ReadLine();
            Console.WriteLine(await CallApi());
        }

        async static Task<string> CallApi()
        {
            using var client = new HttpClient();
            var message = new HttpRequestMessage(HttpMethod.Get, $"{HOST_API}/hotels");

            message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await Token());

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return "Failed";
        }

        static async Task<string> Token()
        {
            using var client = new HttpClient();

            var message = new HttpRequestMessage(HttpMethod.Post, $"{ID_HOST}/connect/token");

            message.Content = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                {"client_id", "0931e822-7bb5-4971-bf64-9c20520c2afb"},
                {"client_secret", "d355c1fb-5b8a-4881-9abc-53dba0b62286"},
                {"grant_type", "client_credentials"},
                {"scope", "hotel.read"}
            });

            var response = await client.SendAsync(message);

            var body = await response.Content.ReadAsStringAsync();

            return JObject.Parse(body).Value<string>("access_token");
        }
    }
}
