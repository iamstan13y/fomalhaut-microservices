using Shopping.Aggregrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<Catalog>> GetCatalog();
        Task<IEnumerable<Catalog>> GetCatalogCategory(string category);
        Task<IEnumerable<Catalog>> GetCatalog(string id);
    }
}
