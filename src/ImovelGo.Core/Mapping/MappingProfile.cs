using System;
using AutoMapper;
using ImovelGo.Core.Domain;
using ImovelGo.Core.Entities;

namespace ImovelGo.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountDTO, Account>().ReverseMap();
            CreateMap<PageDTO, Page>().ReverseMap();
            CreateMap<AreaDTO, Area>().ReverseMap();
            CreateMap<CountryDTO, Country>().ReverseMap();
            CreateMap<CompanyDTO, Company>().ReverseMap();
            CreateMap<AddressDTO, Address>().ReverseMap();
            CreateMap<CompanyAddressDTO, CompanyAddress>().ReverseMap();
            CreateMap<NeighborhoodDTO, Neighborhood>().ReverseMap();
            CreateMap<CityDTO, City>().ReverseMap();
            CreateMap<StateDTO, State>().ReverseMap();
            CreateMap<CountryDTO, Country>().ReverseMap();
            CreateMap<ZoneDTO, Zone>().ReverseMap();
            CreateMap<TemplateDTO, Template>().ReverseMap();
            CreateMap<CompanyPageDTO, CompanyPage>().ReverseMap();
            CreateMap<PropertyDTO, Property>().ReverseMap();
            CreateMap<PropertyTypeDTO, PropertyType>().ReverseMap();
            CreateMap<BrokerDTO, Broker>().ReverseMap();
            CreateMap<PropertyPhotoDTO, PropertyPhoto>().ReverseMap();
            CreateMap<ReviewDTO, Review>().ReverseMap();
            CreateMap<PostCategoryDTO, PostCategory>().ReverseMap();
            CreateMap<PostCommentDTO, PostComment>().ReverseMap();
            CreateMap<PostDTO, Post>().ReverseMap();
        }
    }
}
