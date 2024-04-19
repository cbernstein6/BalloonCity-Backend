using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalloonCity_Backend.Dtos;
using BalloonCity_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace BalloonCity_Backend.Services
{
    public interface IFormServices
    {
        Task<FormDataDto> GetForms();
        Task<FormDataDto> GetForm(int id);
        Task<FormDataDto> AddForm(FormData form);
        Task<FormDataDto> UpdateForm(int id, FormData form);
        Task<FormDataDto> DeleteForm(int id);
    }
}