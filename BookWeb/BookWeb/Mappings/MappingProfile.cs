using AutoMapper;
using BookWeb.DTO;
using BookWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Mappings
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>()
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
              .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
              .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role));

            CreateMap<Role, RoleDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            CreateMap<Book, BookDTO>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
             .ForMember(dest => dest.NameBook, opt => opt.MapFrom(src => src.NameBook))
             .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
             .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
             .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.Deleted))
             .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount))
             .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
          .ForMember(dest => dest.BookImg, opt => opt.MapFrom(src => src.BookImg))
          .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
          .ForMember(dest => dest.CreatedUser, opt => opt.MapFrom(src => src.CreatedUser))
          .ForMember(dest => dest.UpdateUser, opt => opt.MapFrom(src => src.UpdateUser));
        }
    }
}
