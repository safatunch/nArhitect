﻿using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Dtos;
using Application.Features.Brands.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreatedBrandDto>();

            CreateMap<CreateBrandCommand, Brand>();

            CreateMap<IPaginate<Brand>, BrandListModel>();

            CreateMap<Brand, BrandListDto>();

            CreateMap<Brand, BrandGetByIdDto>();
        }
    }
}
