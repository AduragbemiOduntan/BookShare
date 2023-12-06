using AutoMapper;
using BookShare.Appliation.DTOs;
using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Appliation.DTOs.DtoForRead;
using BookShare.Appliation.DTOs.DtoForUpdate;
using BookShare.Domain.Entities;

namespace BookShare.WebAPI
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping() 
        {
            /*CreateMap<UserForCreation, User>();*/
            CreateMap<UserForUpdate, User>();
            CreateMap<User, UserForRead>();

            CreateMap<DonationForCreation, Donation>();
            CreateMap<Donation, DonationForRead>();

            CreateMap<BookForCreation, Book>();
            CreateMap<BookForUpdate, Book>();
            CreateMap<Book, BookForRead>();

            CreateMap<BookCategoryForCreation, BookCategory>();
            CreateMap<BookCategory, BookCategoryForRead>();

            CreateMap<UserForRegistrationDto, User>();

        }
    }
}
