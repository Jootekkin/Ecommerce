using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IProductService
    {
        Task<IReadOnlyList<Product>> GetAllProductsAsync();
    }
}
