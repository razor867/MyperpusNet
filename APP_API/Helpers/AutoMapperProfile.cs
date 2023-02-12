using System;
using System.Linq;
using APP_API.Model;
using APP_API.ViewModel;
using AutoMapper;

namespace APP_API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<book, bookViewModelDto>()
                .ForMember(des => des.BookId, opt => opt.MapFrom(src => src.book_id))
                .ForMember(des => des.BookName, opt => opt.MapFrom(src => src.book_name))
                .ForMember(des => des.BookCategory, opt => opt.MapFrom(src => src.book_category))
                .ForMember(des => des.BookAuthor, opt => opt.MapFrom(src => src.book_author))
                .ForMember(des => des.Publisher, opt => opt.MapFrom(src => src.publisher))
                .ForMember(des => des.PublicationDate, opt => opt.MapFrom(src => CommonMethod.NumericToDate(src.publication_date)))
                .ForMember(des => des.Status, opt => opt.MapFrom(src => src.status))
                .ForMember(des => des.BookStock, opt => opt.MapFrom(src => src.book_stock));
        }
    }
}