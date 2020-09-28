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
    public class BaseController<TModel,TSearch> : ControllerBase
    {

        private readonly IService<TModel,TSearch> service;


        public BaseController(IService<TModel,TSearch> _service)
        {
            service= _service;


        }


        //Get Autor
        [HttpGet]
        public ActionResult<List<TModel>> get([FromQuery]TSearch search)
        {
            var list = service.Get(search);

            return Ok(list);
        }


        //Get AutorbyID
        [HttpGet("{id}")]
        public ActionResult<TModel> GetById(int id)
        {
            return  service.GetById(id);
          
        }


    }
}