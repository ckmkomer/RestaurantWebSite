using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DtoLayer.Dto.About;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;



        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult AboutList()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAbout(CreateAboutDto createAboutDto)
        {
            var values = _mapper.Map<CreateAboutDto, About>(createAboutDto);
            _aboutService.TAdd(values);
            return Ok("Başarılı Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id) 
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("Başırılı Şekilde Silindi");
        }

		[HttpGet("{id}")]
		public IActionResult GetAbout(int id)
		{
			var values = _aboutService.TGetByID(id);
			return Ok(values);
		}

		[HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var values =  _mapper.Map<UpdateAboutDto, About>(updateAboutDto);
            _aboutService.TUpdate(values);
            return Ok("Başarılı şekilde Güncellendi");
                
        }

       
    }
}
