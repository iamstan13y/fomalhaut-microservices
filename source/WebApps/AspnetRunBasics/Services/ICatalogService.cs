using Shopping.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Web.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<Catalog>> GetCatalog();
        Task<IEnumerable<Catalog>> GetCatalogCategory(string category);
        Task<Catalog> GetCatalog(string id);
        Task<Catalog> CreateCatalog(Catalog catalog);
    }
}
