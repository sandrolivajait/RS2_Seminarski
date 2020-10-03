using System;
using System.Collections.Generic;
using System.Text;
using Model.Database;

namespace ServiceLayer.Interfaces
{
    public interface IGradoviService
    {

        IEnumerable<Grad> GetGradovi();
        Grad GetGrad(int id);
    }
}
