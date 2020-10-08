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
    public class AdministratorController : ControllerBase
    {

        private readonly IAuthService _service;
        private readonly IAdministratorService _administratorService;

        public AdministratorController(IAuthService service, IAdministratorService _administratorService)
        {
            _service = service;
            this._administratorService = _administratorService;
        }

        [HttpGet]
        [Route("Authenticiraj/{username},{password}")]
        public Model.Models.Administrator Authenticiraj(string username, string password)
        {
            return _service.AuthenticirajAdmin(username, password);
        }

        [HttpGet]
        public IEnumerable<Administrator> Get()
        {
            return _administratorService.GetAll();
        }

        [HttpGet("{id}")]
        public Administrator GetById(int id)
        {
            return _administratorService.GetAdministrator(id);
        }

        [HttpPost]
        public void Insert(AdministratorInsertRequest request)
        {
            _administratorService.Insert(request);
        }
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] AdministratorInsertRequest request)
        {
            _administratorService.Update(id, request);
        }
    }
}
