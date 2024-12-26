using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Abstract
{
    public interface ILogDal: IGenericDal<Log>
    {
        List<Log> SearchLog(string tc);
    }
}
