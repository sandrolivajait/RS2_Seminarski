using System;
using System.Collections.Generic;
using System.Text;
using Model.Database;

namespace ServiceLayer.Interfaces
{
    public interface ILogService
    {
        void InsertLog(Log kupac);
    }
}
