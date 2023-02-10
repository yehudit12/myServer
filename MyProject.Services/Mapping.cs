using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            //CreateMap<Role, RoleDTO>().ReverseMap();
            //CreateMap<Permission, PermissionDTO>().ReverseMap();
            //CreateMap<Claim, ClaimDTO>()
            //    .ForMember(dest=>dest.Policy,opt=>opt.MapFrom(src=>src.Policy))
            //    .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
            //    .ForMember(dest => dest.Permission, opt => opt.MapFrom(src => src.Permission))
            //    .ReverseMap();
            //CreateMap<User, UserDTO>()
            //    .ForMember(dest => dest.Place, opt => opt.MapFrom(src => src.Place))
            //    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
            //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
            //    .ReverseMap();
            CreateMap<User, UserDTO>().ForMember(dest=>dest.HMO,opt=>opt.MapFrom(src=>src.HMO))
                .ForMember(dest=>dest.Kind,opt=>opt.MapFrom(src=>src.Kind)).ReverseMap();
            CreateMap<Children, ChildrenDTO>().ReverseMap();


        }
    }
}
