using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using ServiceLayer.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NarudzbaController : ControllerBase
    {
        private readonly INarudzbaService _narudzbaService;

        public NarudzbaController(INarudzbaService narudzbaService)
        {
            _narudzbaService = narudzbaService;
        }

        [HttpGet]
        public IEnumerable<Narudzba> Get()
        {
            return _narudzbaService.GetAll();
        }

        [HttpGet("{id}")]
        public Narudzba GetById(int id)
        {
            return _narudzbaService.GetNarudzba(id);
        }
    }
}
