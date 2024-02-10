using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.Concrete;
using Restaurant.DtoLayer.Dto.About;
using Restaurant.DtoLayer.Dto.ProductDto;
using Restaurant.DtoLayer.ProductDto;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly Context _context;

        public ProductController(IProductService productService, IMapper mapper, Context context)
        {
            _productService = productService;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]

        public IActionResult ProductList()
        {
            var values = _productService.TGetList();
            return Ok(values);
        }

        [HttpGet("GetProductsCategories")]
        public IActionResult GetProductsCategories() 
        {
            //List<ResultProductWithCategory> products =_productService.TGetProductsCategories();
            //List<ResultProductWithCategory> mapRespons = _mapper.Map<List<ResultProductWithCategory>>(products);
            //for (int i = 0; i < mapRespons.Count; i++)
            //{
            //    mapRespons[i].CategoryName = products[i].CategoryName;
            //}
            //return Ok(mapRespons);

            var context = new Context();

            var values = context.Products.Include(x => x.Category).Select(t => new ResultProductWithCategory
            {
                Description = t.Description,
                ImageUrl=t.ImageUrl,
                Price = t.Price,
                Id = t.Id,
                Name = t.Name,
                Status=t.Status,
                CategoryName = t.Name
               

            });
            return Ok(values.ToList());
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductDto createProductDto)
        {
            var values = _mapper.Map<CreateProductDto, Product>(createProductDto);
            _productService.TAdd(values);
            return Ok("Başarılı Şekilde Eklendi");
        }

        [HttpDelete ("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Başırılı Şekilde Silindi");
        }

		[HttpGet("{id}")]
		public IActionResult GetProduct(int id)
		{
			var values = _productService.TGetByID(id);
			return Ok(values);
		}

		[HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            var values = _mapper.Map<UpdateProductDto, Product>(updateProductDto);
            _productService.TUpdate(values);
            return Ok("Başarılı şekilde Güncellendi");
        }

        
    }
}
