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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia t)
        {
            _socialMediaDal.Add(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialMediaDal.Delete(t);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaDal.GetByID(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMediaDal.GetList();
        }

        public List<SocialMedia> TGetListbyFilter(int id)
        {
            return _socialMediaDal.GetByFilter(x => x.Id == id);
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMediaDal.Update(t);
        }
    }
}
