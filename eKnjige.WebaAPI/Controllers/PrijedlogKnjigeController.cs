using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using eKnjige.Model;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKnjige.WebaAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PrijedlogKnjigeController : BaseCRUDController<Model.PrijedlogKnjiga, Model.PrijedlogKnjigaRequest, Model.PrijedlogKnjigaRequest, Model.PrijedlogKnjigaRequest>
    {
        public PrijedlogKnjigeController(ICRUDService<Model.PrijedlogKnjiga, PrijedlogKnjigaRequest, PrijedlogKnjigaRequest, PrijedlogKnjigaRequest> _service) : base(_service)
        {
        }

       
    }
}