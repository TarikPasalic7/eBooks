using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKnjige.Model;
using eKnjige.Model.Requests;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKnjige.WebaAPI.Controllers
{

    public class DrzavaController : BaseCRUDController<Model.Drzava, Model.Drzava, Model.Drzava, Model.DrzavaRequest>
    {
        public DrzavaController(ICRUDService<Model.Drzava, Model.Drzava, Model.Drzava, Model.DrzavaRequest> _service) : base(_service)
        {
           
        }
    }
}