﻿using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Abstract
{
    public interface ICargoCompanyService : IGenericService<CargoCompany>
    {
        public IQueryable<CargoCompany> GetAllPC();
    }
}
