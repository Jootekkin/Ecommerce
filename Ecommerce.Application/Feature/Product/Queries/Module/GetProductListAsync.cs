using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Feature.Product.Queries.Module
{
    public class GetProductListAsync :IRequest<IReadOnlyList<ProductDto>>
    {
    }
}
