using Shopping.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.Web.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<Catalog>> GetCatalog();
        Task<IEnumerable<Catalog>> GetCatalogByCategory(string category);
        Task<Catalog> GetCatalog(string id);
        Task<Catalog> CreateCatalog(Catalog catalog);
    }
}
