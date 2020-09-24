using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace ServiceLayer.Classes
{
    public class LogService : ILogService
    {
        private readonly IRepository<Log> logRepository;

        public LogService(IRepository<Log> logRepository)
        {
            this.logRepository = logRepository;
        }

        public void InsertLog(Log kupac)
        {
            logRepository.Insert(kupac);
        }
    }
}
