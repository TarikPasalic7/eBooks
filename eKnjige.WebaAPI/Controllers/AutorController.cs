using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKnjige.Model;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace eKnjige.WebaAPI.Controllers
{
    [Authorize]
    public class AutorController : BaseCRUDController<Model.Autor,Model.AutorSearchRequest,Model.Autor,Model.Autor>
    {
        public AutorController(ICRUDService<Model.Autor, Model.AutorSearchRequest, Model.Autor, Model.Autor> _service) : base(_service)
        {

        }

    }
}