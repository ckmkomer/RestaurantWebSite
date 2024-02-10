using Restaurant.CoreLayer.DataAccessLayer.Abstract;
using Restaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccessLayer.Abstract
{
    public interface IProductDal :IGenericDal<Product>
    {
        List<Product> GetProductsCategories();
    }
}
