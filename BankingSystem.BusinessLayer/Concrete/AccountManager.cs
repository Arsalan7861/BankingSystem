using BankingSystem.BusinessLayer.Abstract;
using BankingSystem.DataAccessLayer.Concrete;
using BankingSystem.EntityLayer.Models;
using System;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLayer.Concrete
{
    public class AccountManager : IAccountService
    {
        private readonly AccountDal _accountDal;

        public AccountManager(string connectionString)
        {
            _accountDal = new AccountDal(connectionString);
        }

        public void Add(Account entity)
        {
            _accountDal.Add(entity);
        }

        public void Delete(int id)
        {
            var account = _accountDal.GetById(id);
            if (account != null)
            {
                _accountDal.Delete(account);
            }
        }

        public List<Account> GetAll()
        {
            return _accountDal.GetAll();
        }

        public Account GetById(int id)
        {
            return _accountDal.GetById(id);
        }

        public void Update(Account entity)
        {
            _accountDal.Update(entity);
        }
    }
}




