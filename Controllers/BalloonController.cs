using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalloonCity_Backend.Dtos;
using BalloonCity_Backend.Models;
using BalloonCity_Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace BalloonCity_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BalloonController : Controller
    {
        public BalloonController(){}
        [HttpGet]
        public async Task<ActionResult<FormDataDto>> GetForms([FromServices] IFormServices services){
            return Ok(services.GetForms());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<FormDataDto>> GetForm([FromServices] IFormServices services, int id){
            return Ok(services.GetForm(id));
        }
        [HttpPost]
        public async Task<ActionResult<FormDataDto>> AddForm([FromServices] IFormServices services, FormData form){
            return Ok(services.AddForm(form));
        }
        [HttpPut]
        public async Task<ActionResult<FormDataDto>> EditForm([FromServices] IFormServices services, int id, FormData form){
            return Ok(services.UpdateForm(id, form));
        }
        [HttpDelete]
        public async Task<ActionResult<FormDataDto>> DeleteForm([FromServices] IFormServices services, int id){
            return Ok(services.DeleteForm(id));
        }
   


    }
}