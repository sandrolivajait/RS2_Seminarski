using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Database;
using ServiceLayer.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NarudzbeStanjaController : ControllerBase
    {
        private readonly INarudzbaService _service;

        public NarudzbeStanjaController(INarudzbaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Model.Database.StanjeNarudzbe> Get()
        {
           return _service.GetStanjaNarudzbi();
        }

    }
}
