using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DtoLayer.Dto.About;
using Restaurant.DtoLayer.FeatureDto;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
      private readonly IFeatureService _featureService;
        private IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult FeatureList()
        {
            var values = _featureService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddFeature(CreateFeatureDto createFeatureDto)
        {
            var values = _mapper.Map<CreateFeatureDto, Feature>(createFeatureDto);
            _featureService.TAdd(values);
            return Ok("Başarılı Şekilde Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Başırılı Şekilde Silindi");
        }

        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var values = _mapper.Map<UpdateFeatureDto, Feature>(updateFeatureDto);
            _featureService.TUpdate(values);
            return Ok("Başarılı şekilde Güncellendi");

        }

        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var values = _featureService.TGetByID(id);
            return Ok(values);
        }
    }
}
