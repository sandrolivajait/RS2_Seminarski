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
    public class KvarStanjaController : ControllerBase
    {
        private readonly IKvarService _service;

        public KvarStanjaController(IKvarService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<StanjeKvara> Get()
        {
           return _service.GetStanjaKvara();
        }

    }
}
