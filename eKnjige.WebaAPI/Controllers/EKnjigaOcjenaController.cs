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
    [Route("api/[controller]")]
    [ApiController]
    public class EKnjigaOcjenaController : BaseCRUDController<Model.KlijentKnjigaOcjena, Model.KlijentKnjigaOcjena, Model.KlijentKnjigaOcijenaRequest, Model.KlijentKnjigaOcijenaRequest>
    {
        public EKnjigaOcjenaController(ICRUDService<Model.KlijentKnjigaOcjena, Model.KlijentKnjigaOcjena, KlijentKnjigaOcijenaRequest, KlijentKnjigaOcijenaRequest> _service) : base(_service)
        {
        }
    }
}