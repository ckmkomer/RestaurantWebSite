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
    public class FooterManager : IFooterService
    {
      private readonly  IFooterDal   _footerDal;

        public FooterManager(IFooterDal footerDal)
        {
            _footerDal = footerDal;
        }

        public void TAdd(Footer t)
        {
            _footerDal.Add(t);
        }

        public void TDelete(Footer t)
        {
            _footerDal.Delete(t);
        }

        public Footer TGetByID(int id)
        {
          return  _footerDal.GetByID(id);
        }

        public List<Footer> TGetList()
        {
          return  _footerDal.GetList();
        }

        public List<Footer> TGetListbyFilter(int id)
        {
            return _footerDal.GetByFilter(x => x.Id == id);
        }

        public void TUpdate(Footer t)
        {
            _footerDal.Update(t);
        }
    }
}
