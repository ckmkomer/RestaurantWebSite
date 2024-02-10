using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DtoLayer.Dto.About;
using Restaurant.DtoLayer.Dto.Footer;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterController :ControllerBase
    {
      private readonly IFooterService _footerService;
     private   IMapper _mapper;

        public FooterController(IFooterService footerService, IMapper mapper)
        {
            _footerService = footerService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult FooterList()
        {
            var values = _footerService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddFooter(CreateFooterDto createFooterDto)
        {
            var values = _mapper.Map<CreateFooterDto, Footer>(createFooterDto);
            _footerService.TAdd(values);
            return Ok("Başarılı Şekilde Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteFooter(int id)
        {
            var value = _footerService.TGetByID(id);
            _footerService.TDelete(value);
            return Ok("Başırılı Şekilde Silindi");
        }

        [HttpPut]
        public IActionResult UpdateFooter(UpdateFooterDto updateFooterDto)
        {
            var values = _mapper.Map<UpdateFooterDto, Footer>(updateFooterDto);
            _footerService.TUpdate(values);
            return Ok("Başarılı şekilde Güncellendi");

        }

        [HttpGet("GetFooter")]
        public IActionResult GetFooter(int id)
        {
            var values = _footerService.TGetByID(id);
            return Ok(values);
        }
    }
}
