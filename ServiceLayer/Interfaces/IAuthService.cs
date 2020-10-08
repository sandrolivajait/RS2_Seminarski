using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IAuthService
    {
        public Model.Models.Administrator AuthenticirajAdmin(string username, string password);
    }
}
