using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLayer.Abstract
{
    public interface ILogService: IGenericService<Log>
    {
        List<Log> TSearchLog(string tc);
    }
}
