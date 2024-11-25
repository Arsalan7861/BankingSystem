using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingSystem.BusinessLayer.Abstract
{
    public interface ITransactionService : IGenericService<Transaction>
    {
    }
}
