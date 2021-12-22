using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<T> ReadContentAs<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
                throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");

            var stringData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(stringData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
