using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.Abstract;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
      private readonly  IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Add(t);
        }

        public void TDelete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public Reservation TGetByID(int id)
        {
            return _reservationDal.GetByID(id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public List<Reservation> TGetListbyFilter(int id)
        {
            return _reservationDal.GetByFilter(x => x.Id == id);
        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }
    }
}
