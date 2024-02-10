using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DtoLayer.Dto.ReservationDto;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
       private readonly IReservationService _reservationService;
       private IMapper _mapper;

        public ReservationController(IReservationService reservationService, IMapper mapper)
        {
            _reservationService = reservationService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult ReservationList()
        {
            var values = _reservationService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddReservation(CreateReservationDto createReservationDto)
        {
            var values = _mapper.Map<CreateReservationDto, Reservation>(createReservationDto);
            _reservationService.TAdd(values);
            return Ok("Başarılı Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReservation(int id)
        {
            var value = _reservationService.TGetByID(id);
            _reservationService.TDelete(value);
            return Ok("Başırılı Şekilde Silindi");
        }

        [HttpPut]
        public IActionResult UpdateReservation(UpdateReservationDto updateReservationDto)
        {
            var values = _mapper.Map<UpdateReservationDto, Reservation>(updateReservationDto);
            _reservationService.TUpdate(values);
            return Ok("Başarılı şekilde Güncellendi");

        }

        [HttpGet("{id}")]
        public IActionResult GetReservation(int id)
        {
            var values = _reservationService.TGetByID(id);
            return Ok(values);
        }
    }
}
