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
    public class EKnjigaAutorController : BaseCRUDController<Model.EKnjigeAutor, Model.EKnjigeAutor, Model.EKnjigeAutorRequest, Model.EKnjigeAutorRequest>
    {
        public EKnjigaAutorController(ICRUDService<Model.EKnjigeAutor, Model.EKnjigeAutor, EKnjigeAutorRequest, EKnjigeAutorRequest> _service) : base(_service)
        {
        }
    }
}