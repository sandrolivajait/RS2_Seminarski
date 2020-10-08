using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Requests;
using ServiceLayer.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KupacController : ControllerBase
    {
        
        private readonly IKupacService _kupacService;

        public KupacController(IKupacService _kupacService)
        {
            this._kupacService = _kupacService;
        }

       

        [HttpGet]
        public IEnumerable<Model.Models.Kupac> Get()
        {
            return _kupacService.GetAll();
        }

        [HttpGet("{id}")]
        public Model.Models.Kupac GetById(int id)
        {
            return _kupacService.GetKupac(id);
        }

        [HttpPost]
        public void Insert(KupacInsertRequest request)
        {
            //Model.Models.Kupac.Insert(request);
        }
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] KupacInsertRequest request)
        {
            _kupacService.Update(id, request);
        }
    }
}
