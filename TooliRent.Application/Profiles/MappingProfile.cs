using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooliRent.Application.DTOs;
using TooliRent.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TooliRent.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Tool <-> DTO
            CreateMap<Tool, ToolDto>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name));
            CreateMap<ToolCreateDto, Tool>();
            CreateMap<ToolUpdateDto, Tool>();

            // Category <-> DTO
            CreateMap<ToolCategory, CategoryDto>();
            CreateMap<CategoryCreateDto, ToolCategory>();

            // Booking <-> DTO
            CreateMap<Booking, BookingDto>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
            CreateMap<BookingItem, BookingItemDto>()
                .ForMember(dest => dest.ToolName, opt => opt.MapFrom(src => src.Tool.Name))
                .ForMember(dest => dest.ToolId, opt => opt.MapFrom(src => src.ToolId));
        }
    }
}

