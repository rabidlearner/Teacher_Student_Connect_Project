using AutoMapper;

using Teacher_Student_Connect_Project.Models;
using Teacher_Student_Connect_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Student_Connect_Project
{
    public class ApiMappings : Profile
    {
        public ApiMappings()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<Document, DocumentViewModel>().ReverseMap();
            CreateMap<Student, StudentViewModel>().ReverseMap();
            CreateMap<Teacher, TeacherViewModel>().ReverseMap();
            CreateMap<Subject, SubjectViewModel>().ReverseMap();
            CreateMap<Batch, BatchViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();

        }
    }
}