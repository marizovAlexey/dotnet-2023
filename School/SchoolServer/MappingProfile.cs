﻿using AutoMapper;
using SchoolServer.Dto;
using School.Classes;

namespace SchoolServer;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Class, ClassGetDto>();
        CreateMap<ClassGetDto, Class>();
        CreateMap<ClassPostDto, Class>();

        CreateMap<Subject, SubjectGetDto>();
        CreateMap<SubjectGetDto, Subject>();
    }
}