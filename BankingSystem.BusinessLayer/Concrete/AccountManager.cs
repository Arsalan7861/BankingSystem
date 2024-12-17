using BankingSystem.BusinessLayer.Abstract;
using BankingSystem.DataAccessLayer.Abstract;
using BankingSystem.EntityLayer.Models;
using System;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLayer.Concrete
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public void TAdd(Account entity)
        {
            _accountDal.Add(entity);
        }

        public void TDelete(int id)
        {
            var account = _accountDal.GetById(id);
            if (account != null)
            {
                _accountDal.Delete(account);
            }
        }

        public void TdepositMoney(string customerTc, decimal amount)
        {
            _accountDal.depositMoney(customerTc, amount);
        }

        public List<Account> TGetAll()
        {
            return _accountDal.GetAll();
        }

        public Account TGetById(int id)
        {
            return _accountDal.GetById(id);
        }

        public void TUpdate(Account entity)
        {
            _accountDal.Update(entity);
        }

        public void TwithdrawMoney(string customerTc, decimal amount)
        {
            _accountDal.withdrawMoney(customerTc, amount);
        }
    }
}




