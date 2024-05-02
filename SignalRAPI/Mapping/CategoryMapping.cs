using AutoMapper;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<CategoryMapping, ResultCategoryDto>().ReverseMap();
            CreateMap<CategoryMapping, CreateCategoryDto>().ReverseMap();
            CreateMap<CategoryMapping, GetCategoryDto>().ReverseMap();
            CreateMap<CategoryMapping, UpdateCategoryDto>().ReverseMap();
        }
    }
}
