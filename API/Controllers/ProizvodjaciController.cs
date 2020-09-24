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
    public class ProizvodjaciController : ControllerBase
    {
        private readonly IProizvodjacService _service;

        public ProizvodjaciController(IProizvodjacService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Proizvodjac> Get()
        {
            return _service.GetProizvodjaci();
        }
    }
}
