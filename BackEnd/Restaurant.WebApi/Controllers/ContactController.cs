using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DtoLayer.Dto.About;
using Restaurant.DtoLayer.Dto.Contact;
using Restaurant.EntityLayer.Concrete;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
       private readonly IContactService _contactService;
        private IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult ContactList()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAContact(CreateContactDto createContactDto)
        {
            var values = _mapper.Map<CreateContactDto, Contact>(createContactDto);
            _contactService.TAdd(values);
            return Ok("Başarılı Şekilde Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("Başırılı Şekilde Silindi");
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            var values = _mapper.Map<UpdateContactDto, Contact>(updateContactDto);
            _contactService.TUpdate(values);
            return Ok("Başarılı şekilde Güncellendi");

        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var values = _contactService.TGetByID(id);
            return Ok(values);
        }
    }
}
