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
    public class TransactionManager : ITransactionService
    {
        private readonly ITransactionDal _transactionDal;

        public TransactionManager(ITransactionDal transactionDal)
        {
            _transactionDal = transactionDal;
        }

        public void TAdd(Transaction entity)
        {
            _transactionDal.Add(entity);
        }

        public void TDelete(int id)
        {
            var transaction = _transactionDal.GetById(id);
            _transactionDal.Delete(transaction);
        }

        public List<Transaction> TGetAll()
        {
            return _transactionDal.GetAll();
        }

        public Transaction TGetById(int id)
        {
            return _transactionDal.GetById(id);
        }

        public void TUpdate(Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
