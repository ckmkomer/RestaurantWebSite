using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccessLayer.Abstract;
using Restaurant.DataAccessLayer.Concrete;
using Restaurant.DataAccessLayer.Repository;
using Restaurant.DtoLayer.Dto.ProductDto;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {

        public EfProductDal(Context context) : base(context)
        {
        }

        public List<Product> GetProductsCategories()
        {
            var context = new Context();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }



        //public List<ResultProductWithCategory> GetProductsCategories()
        //{
        //    using (Context context = new Context())

        //    {



        //        var value = from c in context.Categories

        //                    join p in context.Products on c.Id equals p.CategoryID

        //                    where (c.Id == p.CategoryID)

        //                    select new ResultProductWithCategory

        //                    {

        //                        CategoryName = c.Name,

        //                        Description = p.Description,

        //                        ImageUrl = p.ImageUrl,

        //                        Price = p.Price,

        //                        Id = p.Id,

        //                        Name = p.Name,

        //                        Status = p.Status,

        //                    };

        //        return value.ToList();

        //    }


    }
        //var context = new Context();
        //var values = _context.Products.Include(x => x.Category).Select(t => new ResultProductWithCategory
        //{
        //    Description = t.Description,
        //    ImageUrl = t.ImageUrl,
        //    Price = t.Price,
        //    Id = t.Id,
        //    Name = t.Name,
        //    Status = t.Status,
        //    CategoryName = t.Category.Name,


    }

           
        




    









//var values = _context.Products.Include(x => x.Category).ToList
//            return values;


