using Model.Models;
using Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IAdministratorService
    {
        public IEnumerable<Administrator> GetAll();
        public void Insert(AdministratorInsertRequest request);

        public void Update(int id, AdministratorInsertRequest request);

        public Administrator GetAdministrator(int id);
    }
}
