using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKnjige.WebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PreporukaController : ControllerBase
    {


        private readonly IPreporukaService _service;

        public PreporukaController(IPreporukaService service)
        {
            _service = service;
        }

        [HttpGet("GetPreporuceneKnjige")]
        public List<Model.EKnjiga> GetPreporuceneKnjige()
        {
            return _service.GetPreporuceneKnjige();
        }

    }
}