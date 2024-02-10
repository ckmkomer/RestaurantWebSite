using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.Abstract;
using Restaurant.DtoLayer.Dto.ProductDto;
using Restaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product t)
        {
            _productDal.Add(t);
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public List<Product> TGetListbyFilter(int id)
        {
            return _productDal.GetByFilter(x=> x.Id == id);
        }

        public List<Product> TGetProductsCategories()
        {
           return _productDal.GetProductsCategories();
        }

        //public List<ResultProductWithCategory> TGetProductsCategories()
        //{

        //    return _productDal.GetProductsCategories();
        //}

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
