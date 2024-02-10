using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.Abstract;
using Restaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void TAdd(Discount t)
        {
            _discountDal.Add(t);
        }

        public void TDelete(Discount t)
        {
            _discountDal.Delete(t);
        }

        public Discount TGetByID(int id)
        {
            return _discountDal.GetByID(id);
        }

        public List<Discount> TGetList()
        {
           return _discountDal.GetList();
        }

        public List<Discount> TGetListbyFilter(int id)
        {
           return _discountDal.GetByFilter(x=>x.Id==id);
        }

        public void TUpdate(Discount t)
        {
            _discountDal.Update(t);
        }
    }
}
