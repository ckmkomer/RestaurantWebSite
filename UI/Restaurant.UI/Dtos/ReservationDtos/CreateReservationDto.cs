
namespace Restaurant.UI.Dtos.ReservationDtos
{
    public class CreateReservationDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PersonCount { get; set; }

        public string Mail { get; set; }

        public DateTime Date { get; set; }
    }
}
