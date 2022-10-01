using AutoMapper;
using DTOdemo_DATA;
using DTOdemo_MODELS;

namespace DTOdemo_BUSINESS.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // map from source -> destination


        CreateMap<Book, BookDTO>().ReverseMap();

        CreateMap<Author, BookAuthorDTO>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src =>src.FirstName + " " + src.MiddleName + " " + src.LastName));

        CreateMap<Author, AuthorDTO>().ReverseMap();
        //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));

        CreateMap<Category, CategoryDTO>().ReverseMap();

        CreateMap<Book, CategoryBookDTO>();

    }
}
