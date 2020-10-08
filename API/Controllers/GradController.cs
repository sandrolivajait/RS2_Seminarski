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
    public class GradController : ControllerBase
    {
        private readonly IGradoviService _gradService;

        public GradController(IGradoviService gradService)
        {
            _gradService = gradService;
        }

        [HttpGet]
        public IEnumerable<Grad> Get()
        {
            return _gradService.GetGradovi();
        }
    }
}
