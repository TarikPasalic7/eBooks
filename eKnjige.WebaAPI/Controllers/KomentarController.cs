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
    public class KomentarController : BaseCRUDController<Model.Komentar, Model.KomentarRequest, Model.KomentarRequest, Model.KomentarRequest>
    {
        public KomentarController(ICRUDService<Model.Komentar, KomentarRequest, KomentarRequest, KomentarRequest> _service) : base(_service)
        {
        }
    }
}