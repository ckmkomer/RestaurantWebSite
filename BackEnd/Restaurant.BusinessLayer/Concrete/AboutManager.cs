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
    public class AboutManager : IAboutService
    {
      private readonly  IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About t)
        {
            _aboutDal.Add(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
          return  _aboutDal.GetByID(id);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public List<About> TGetListbyFilter(int id)
        {
           return _aboutDal.GetByFilter(x => x.Id == id);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
