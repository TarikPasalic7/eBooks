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
    public class EKnjigaKategorijaController : BaseCRUDController<Model.EKnjigaKategorija, Model.EKnjigaKategorija, Model.EKnjigaKategorijaRequest, Model.EKnjigaKategorijaRequest>
    {
        public EKnjigaKategorijaController(ICRUDService<Model.EKnjigaKategorija, Model.EKnjigaKategorija, EKnjigaKategorijaRequest, EKnjigaKategorijaRequest> _service) : base(_service)
        {
        }
    }
}