using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BalloonCity_Backend.Dtos;
using BalloonCity_Backend.Models;

namespace BalloonCity_Backend.Profiles
{
    public class FormProfile : Profile
    {
        public FormProfile(){
            CreateMap<FormData, FormDataDto>();
        }
    }
}