﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestCreacionProyecto.Data;
using TestCreacionProyecto.Models;

namespace TestCreacionProyecto.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public  async Task<IActionResult> Index()
        {
            return View(await _context.Usuario.ToListAsync());
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration =0, Location = ResponseCacheLocation.None, NoStore =true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
