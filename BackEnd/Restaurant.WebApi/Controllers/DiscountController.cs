using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DtoLayer.DiscountDto;
using Restaurant.DtoLayer.Dto.About;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        IDiscountService _discountService;
        IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _discountService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddDiscount(CreateDiscountDto createDiscountDto)
        {
            var values = _mapper.Map<CreateDiscountDto, Discount>(createDiscountDto);
            _discountService.TAdd(values);
            return Ok("Başarılı Şekilde Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("Başırılı Şekilde Silindi");
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            var values = _mapper.Map<UpdateDiscountDto, Discount>(updateDiscountDto);
            _discountService.TUpdate(values);
            return Ok("Başarılı şekilde Güncellendi");
        }

        [HttpGet("GetDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var values = _discountService.TGetByID(id);
            return Ok(values);
        }
    }
}
