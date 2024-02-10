namespace Restaurant.UI.Dtos.ReservationDtos
{
    public class UpdateReservationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PersonCount { get; set; }

        public string Mail { get; set; }

        public DateTime Date { get; set; }
    }
}
