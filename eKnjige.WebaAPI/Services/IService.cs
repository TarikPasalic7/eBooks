﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
    public  interface IService<TModel,TSearch>
    {

        List<TModel> Get(TSearch search);

        TModel GetById(int id);

        
    }
}
