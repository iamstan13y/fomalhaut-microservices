using Catalog.API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
