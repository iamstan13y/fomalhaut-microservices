using Shopping.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task<Catalog> CreateCatalog(Catalog catalog)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Catalog>> GetCatalog()
        {
            throw new NotImplementedException();
        }

        public Task<Catalog> GetCatalog(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Catalog>> GetCatalogCategory(string category)
        {
            throw new NotImplementedException();
        }
    }
}
