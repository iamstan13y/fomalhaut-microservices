using Shopping.Web.Extensions;
using Shopping.Web.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shopping.Web.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly HttpClient _client;

        public CatalogService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<Catalog>> GetCatalog()
        {
            var response = await _client.GetAsync("/Catalog");
            return await response.ReadContentAs<List<Catalog>>();
        }

        public async Task<Catalog> GetCatalog(string id)
        {
            var response = await _client.GetAsync($"/Catalog/{id}");
            return await response.ReadContentAs<Catalog>();
        }

        public async Task<IEnumerable<Catalog>> GetCatalogByCategory(string category)
        {
            var response = await _client.GetAsync($"/Catalog/GetProductByCategory/{category}");
            return await response.ReadContentAs<List<Catalog>>();
        }

        public async Task<Catalog> CreateCatalog(Catalog model)
        {
            var response = await _client.PostAsJson($"/Catalog", model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<Catalog>();
            else
            {
                throw new Exception("Something went wrong when calling API.");
            }
        }
    }
}
