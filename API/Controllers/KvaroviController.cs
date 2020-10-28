using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Model.Requests;
using ServiceLayer.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KvaroviController : ControllerBase
    {
        private readonly IKvarService _service;

        public KvaroviController(IKvarService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Kvar> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public Kvar GetById(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public void Insert(KvarInsertRequest request)
        {
            _service.Insert(request);
        }
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] KvarInsertRequest request)
        {
            _service.Update(id, request);
        }
    }
}
