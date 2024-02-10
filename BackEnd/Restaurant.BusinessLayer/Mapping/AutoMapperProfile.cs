using AutoMapper;
using Restaurant.DtoLayer.DiscountDto;
using Restaurant.DtoLayer.Dto.About;
using Restaurant.DtoLayer.Dto.Category;
using Restaurant.DtoLayer.Dto.Contact;
using Restaurant.DtoLayer.Dto.Footer;
using Restaurant.DtoLayer.Dto.ProductDto;
using Restaurant.DtoLayer.Dto.ReservationDto;
using Restaurant.DtoLayer.FeatureDto;
using Restaurant.DtoLayer.ProductDto;
using Restaurant.DtoLayer.SocialMediaDto;
using Restaurant.DtoLayer.TestimonialDto;
using Restaurant.EntityLayer.Concrete;
using SignalR.DtoLayer.ProductDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BusinessLayer.Mapping
{
    public class AutoMapperProfile : Profile
    {
       public AutoMapperProfile()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();


            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();

            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();

            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategory>().ReverseMap();

            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();


            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();

            CreateMap<Footer, ResultFooterDto>().ReverseMap();
            CreateMap<Footer, UpdateFooterDto>().ReverseMap();
            CreateMap<Footer, CreateFooterDto>().ReverseMap();
            CreateMap<Footer, GetFooterDto>().ReverseMap();

            CreateMap<Reservation, ResultReservationDto>().ReverseMap();
            CreateMap<Reservation, UpdateReservationDto>().ReverseMap();
            CreateMap<Reservation, CreateReservationDto>().ReverseMap();
            CreateMap<Reservation, GetReservationDto>().ReverseMap();
        }
    }
}
