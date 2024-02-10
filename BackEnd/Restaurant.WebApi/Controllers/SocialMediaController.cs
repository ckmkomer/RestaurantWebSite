using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DtoLayer.Dto.About;
using Restaurant.DtoLayer.SocialMediaDto;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult SocialMediaList()
        {
            var values = _socialMediaService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAbout(CreateSocialMediaDto createSocialMediaDto)
        {
            var values = _mapper.Map<CreateSocialMediaDto, SocialMedia>(createSocialMediaDto);
            _socialMediaService.TAdd(values);
            return Ok("Başarılı Şekilde Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Başırılı Şekilde Silindi");
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var values = _mapper.Map<UpdateSocialMediaDto, SocialMedia>(updateSocialMediaDto);
            _socialMediaService.TUpdate(values);
            return Ok("Başarılı şekilde Güncellendi");

        }

        [HttpGet("GetSocialMedia")]
        public IActionResult GetAbout(int id)
        {
            var values = _socialMediaService.TGetByID(id);
            return Ok(values);
        }
    }
}
