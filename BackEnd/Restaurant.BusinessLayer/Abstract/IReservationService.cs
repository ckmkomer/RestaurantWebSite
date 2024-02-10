using Restaurant.CoreLayer.GenericService;
using Restaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BusinessLayer.Abstract
{
    public interface IReservationService :IGenericService<Reservation>
    {
    }
}
