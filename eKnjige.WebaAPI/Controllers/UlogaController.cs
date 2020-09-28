using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKnjige.Model;
using eKnjige.Model.Requests;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKnjige.WebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogaController : BaseCRUDController<Model.Uloga,Model.UlogeRequest,Model.UlogeRequest,Model.UlogeRequest>
    {
        public UlogaController(ICRUDService<Model.Uloga, Model.UlogeRequest, Model.UlogeRequest, Model.UlogeRequest> _service) : base(_service)
        {
           
        }
    }
}