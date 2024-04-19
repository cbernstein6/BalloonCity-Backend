using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BalloonCity_Backend.Dtos;
using BalloonCity_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace BalloonCity_Backend.Services
{
    public class FormServices : IFormServices
    {
        private readonly IMapper _mapper;

        public FormServices(IMapper mapper){
            _mapper = mapper;
        }

       public Task<FormDataDto> GetForms()
        {
            throw new NotImplementedException();
        }
         public Task<FormDataDto> GetForm(int id)
        {
            throw new NotImplementedException();
        }

        
        public async Task<FormDataDto> AddForm(FormData form)
        {
            string message = $"From {form.email} | ({form.name}):\n\n{form.message}";
            EmailService.SendEmail(message);
            FormDataDto dto = _mapper.Map<FormDataDto>(form);
            return dto;
        }

        public Task<FormDataDto> DeleteForm(int id)
        {
            throw new NotImplementedException();
        }
        
        public Task<FormDataDto> UpdateForm(int id, FormData form)
        {
            throw new NotImplementedException();
        }

        
    }
}