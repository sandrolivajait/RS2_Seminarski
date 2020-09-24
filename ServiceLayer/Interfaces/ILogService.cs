using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace ServiceLayer.Interfaces
{
    public interface ILogService
    {
        void InsertLog(Log kupac);
    }
}
