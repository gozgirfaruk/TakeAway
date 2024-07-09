using AutoMapper;
using TakeAway.CatalogApi.Dtos.CategoryDtos;
using TakeAway.CatalogApi.Dtos.DailyDiscountDtos;
using TakeAway.CatalogApi.Dtos.ProductDtos;
using TakeAway.CatalogApi.Dtos.SliderDtos;
using TakeAway.CatalogApi.Entities;

namespace TakeAway.CatalogApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<DailyDiscount, ResultDailyDiscountDto>().ReverseMap();
            CreateMap<DailyDiscount, CreateDailyDiscountDto>().ReverseMap();
            CreateMap<DailyDiscount, UpdateDailyDiscountDto>().ReverseMap();
            CreateMap<DailyDiscount, GetByIdDailyDiscountDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();

            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, GetByIdSliderDto>().ReverseMap();

        }
    }
}
