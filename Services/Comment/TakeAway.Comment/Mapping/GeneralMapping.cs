﻿using AutoMapper;
using TakeAway.Comment.Dal.Entities;
using TakeAway.Comment.Dtos;

namespace TakeAway.Comment.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<UserComment,ResultUserCommentDto>().ReverseMap();
            CreateMap<UserComment,GetByIdUserCommentDto>().ReverseMap();
            CreateMap<UserComment,UpdateUserCommentDto>().ReverseMap();
            CreateMap<UserComment,CreateUserCommentDto>().ReverseMap();
        }
    }
}
