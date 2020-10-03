using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using Model.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobiteliController : ControllerBase
    {
        private readonly IMobitelService _service;

        public MobiteliController(IMobitelService service)
        {
            _service = service;
        }


        [HttpGet]
        public IEnumerable<Mobiteli> Get([FromQuery] MobiteliSearchRequest search)
        {
            return _service.GetMobiteli(search);
        }

        [HttpGet("{id}")]
        public Mobiteli GetById(int id)
        {
            return _service.GetMobitel(id);
        }
        
        [HttpPost]
        public void Insert(MobiteliInsertRequest request)
        {
            _service.Insert(request);
        }
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] MobiteliInsertRequest request)
        {
            _service.Update(id, request);
        }
    }
}
