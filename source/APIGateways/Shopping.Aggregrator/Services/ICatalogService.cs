using Shopping.Aggregrator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<Catalog>> GetCatalog();
        Task<IEnumerable<Catalog>> GetCatalogCategory(string category);
        Task<Catalog> GetCatalog(string id);
    }
}
