using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete.EntityFramework;

namespace Core.Specifications
{
    public class ProductWithTypeAndBrands : BaseSpecifications<Product>
    {
        public ProductWithTypeAndBrands()
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }
    }
}
