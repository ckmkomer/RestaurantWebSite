using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DtoLayer.Dto.Category;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
       private readonly ICategoryService _categoryService;
      private  IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCategory(CreateCategoryDto createCategoryDto)
        {
            var values = _mapper.Map<CreateCategoryDto, Category>(createCategoryDto);
            _categoryService.TAdd(values);
            return Ok("Başarılı Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("Başırılı Şekilde Silindi");
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var values = _mapper.Map<UpdateCategoryDto, Category>(updateCategoryDto);
            _categoryService.TUpdate(values);
            return Ok("Başarılı şekilde Güncellendi");

        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values = _categoryService.TGetByID(id);
            return Ok(values);
        }
    }
}
