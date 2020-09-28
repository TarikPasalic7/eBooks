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
    public class GradController : BaseCRUDController<Model.Grad, Model.Grad, Model.Grad, Model.Grad>
    {
        public GradController(ICRUDService<Model.Grad, Model.Grad, Model.Grad, Model.Grad> _service) : base(_service)
        {
        }
    }
}