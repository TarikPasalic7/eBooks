using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKnjige.WebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpolController : BaseCRUDController<Model.Spol, Model.Spol, Model.Spol, Model.Spol>
    {
        public SpolController(ICRUDService<Model.Spol, Model.Spol, Model.Spol, Model.Spol> _service) : base(_service)
        {
        }
    }
}