using Microsoft.EntityFrameworkCore;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.BusinessLayer.Concrete;
using Restaurant.BusinessLayer.Mapping;
using Restaurant.DataAccessLayer.Abstract;
using Restaurant.DataAccessLayer.Concrete;
using Restaurant.DataAccessLayer.EntityFramework;
using Restaurant.EntityLayer.Concrete.Identity;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>();

//var connectionString = builder.Configuration.GetConnectionString("DbCon");
//builder.Services.AddDbContext<Context>(x => x.UseSqlServer(connectionString));

builder.Services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<Context>();
//.AddErrorDescriber<CustomIdentityValidator>()

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));


// Add services to the container.


builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IAboutService,AboutManager>();
builder.Services.AddScoped<IAboutDal,EFAboutDal>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();

builder.Services.AddScoped<IDiscountService, DiscountManager>();
builder.Services.AddScoped<IDiscountDal, EfDiscountDal>();

builder.Services.AddScoped<IFeatureService, FeatureManager>();
builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();


builder.Services.AddScoped<IFooterService, FooterManager>();
builder.Services.AddScoped<IFooterDal, EfFooterDal>();

builder.Services.AddScoped<IReservationService, ReservationManager>();
builder.Services.AddScoped<IReservationDal, EfReservationDal>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EfProductDal>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
