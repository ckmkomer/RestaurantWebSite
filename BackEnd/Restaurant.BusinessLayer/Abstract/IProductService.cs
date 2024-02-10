using Restaurant.CoreLayer.GenericService;
using Restaurant.DtoLayer.Dto.ProductDto;
using Restaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BusinessLayer.Abstract
{
   public interface IProductService :IGenericService<Product>
    {
        List<Product> TGetProductsCategories();
    }
}
