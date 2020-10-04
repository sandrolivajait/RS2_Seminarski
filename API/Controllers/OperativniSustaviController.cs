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
    public class OperativniSustaviController : ControllerBase
    {
        private readonly IOperativniSustaviService _service;

        public OperativniSustaviController(IOperativniSustaviService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<OperativniSustav> Get()
        {
            return _service.GetOperativniSustavi();
        }
    }
}
