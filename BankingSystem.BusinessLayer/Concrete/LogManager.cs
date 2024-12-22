using BankingSystem.BusinessLayer.Abstract;
using BankingSystem.DataAccessLayer.Abstract;
using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLayer.Concrete
{
    public class LogManager : ILogService
    {
        private readonly ILogDal _logService;

        public LogManager(ILogDal logService)
        {
            _logService = logService;
        }

        public void TAdd(Log entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Log> TGetAll()
        {
            return _logService.GetAll();
        }

        public Log TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Log entity)
        {
            throw new NotImplementedException();
        }
    }
}
