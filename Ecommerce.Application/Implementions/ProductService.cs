using Ecommerce.Application.Interface;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Implementions
{
    public class ProductService : IProductService
    {

        #region Fields
        private readonly IProductRepository _productRepository;
        #endregion

        #region Constructor
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }
        #endregion

        #region Methods
        public async Task<IReadOnlyList<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }
        #endregion
    }
}
