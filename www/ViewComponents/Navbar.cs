﻿using AutoMapper;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace www.ViewComponents
{
    public class Navbar : ViewComponent
    {
        private readonly IUnitOfWork _uow;
        public Navbar(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
