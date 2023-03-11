using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net.Http.Json;
using WakeBlazor.Models;

namespace WakeBlazor
{
    public class ClientVideo
    {
        HttpClient _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:7099/api/") };

        public List<PostVideo> GetClientVideos()
        {
            List<PostVideo> videos = new List<PostVideo>();

            var response = _httpClient.GetFromJsonAsync<List<PostVideo>>(_httpClient.BaseAddress + "PostVideos");
            response.Wait();

            videos = response.Result;

            return videos;
        }
    }
}
