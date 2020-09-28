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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KategorijaController : BaseCRUDController<Model.Kategorija, object, Model.Requests.KategorijaInertRequest, Model.Requests.KategorijaInertRequest>
    {
        public KategorijaController(ICRUDService<Model.Kategorija, object, Model.Requests.KategorijaInertRequest, Model.Requests.KategorijaInertRequest> _service) : base(_service)
        {
        }
    }
}