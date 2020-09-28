using System;
using System.Collections.Generic;
using System.Linq;
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
    public class KupovinaKnjigeController : BaseCRUDController<Model.KupovinaKnjige, Model.KupovinaKnjigeRequest, Model.KupovinaKnjigeRequest, Model.KupovinaKnjigeRequest>
    {
        public KupovinaKnjigeController(ICRUDService<Model.KupovinaKnjige, KupovinaKnjigeRequest, KupovinaKnjigeRequest, KupovinaKnjigeRequest> _service) : base(_service)
        {
        }
    }
}