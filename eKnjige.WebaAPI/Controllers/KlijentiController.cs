
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKnjige.Model;
using eKnjige.Model.Requests;
using eKnjige.WebaAPI.Data;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKnjige.WebaAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class KlijentiController : ControllerBase
    {

        private readonly IKlijentService _service;
        public KlijentiController(IKlijentService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet]
        public List<Model.Klijent> Get([FromQuery] Model.Requests.KlijentiSearchRequest request)
        {
            return _service.Get(request);
        }

       
        [HttpPost]
        
        public Model.Klijent Insert(Model.KlijentInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize]
        [HttpPut("{id}")]
        
        public Model.Klijent Update(int id, [FromBody]Model.KlijentUpdateRequest request)
        {
            return _service.Update(id, request);
        }
        [Authorize]
        [HttpGet("{id}")]
        public Model.Klijent GetById(int id)
        {
            return _service.GetbyId(id);
        }
        [Authorize]
        [HttpGet("Profil")]
        
        public Model.Klijent Profil()
        {
            return _service.Profil();
        }


        
        [HttpPut("UpdateProfile")]
        public Model.Klijent UpdateProfile([FromBody] Model.KlijentInsertRequest request)
        {
            return _service.UpdateProfile(request);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            return _service.Remove(id);
        }
    }
}