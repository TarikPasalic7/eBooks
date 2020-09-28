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
    public class EKnjigaController : ControllerBase
    {
        private readonly IEKnjigaService ieknjiga;
        public EKnjigaController(IEKnjigaService _iknjiga)
        {
            ieknjiga = _iknjiga;

        }

        //Get Autor
        [HttpGet]
        public List<Model.EKnjiga> Get([FromQuery] Model.Requests.eKnjigeSearchRequest request)
        {
            return ieknjiga.Get(request);
        }

        [HttpGet("{id}")]

        public ActionResult<Model.EKnjiga> getbyId(int id)
        {
            var eknjiga = ieknjiga.getById(id);

            return eknjiga;


        }


        [HttpPost]

        public ActionResult<Model.EKnjiga> Isert(Model.Requests.EKnjigaInsertRequest request)
        {
            var eknjiga = ieknjiga.Insert(request);

            return eknjiga;


        }

        [HttpPut("{id}")]
        public Model.EKnjiga Update(int id, [FromBody]Model.Requests.EKnjigaInsertRequest request)
        {
            return ieknjiga.Update(id,request);
        }

        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            return ieknjiga.Remove(id);
        }

    }
}