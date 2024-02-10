using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.Abstract;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial t)
        {
            _testimonialDal.Add(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
          return  _testimonialDal.GetList();
        }

        public List<Testimonial> TGetListbyFilter(int id)
        {
         return  _testimonialDal.GetByFilter(x=>x.Id == id);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
