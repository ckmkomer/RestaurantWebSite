using Restaurant.DataAccessLayer.Abstract;
using Restaurant.DataAccessLayer.Concrete;
using Restaurant.DataAccessLayer.Repository;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.DataAccessLayer.EntityFramework
{
    public class EFAboutDal : GenericRepository<About>, IAboutDal
    {
        public EFAboutDal(Context context) : base(context)
        {
        }
    }
}
