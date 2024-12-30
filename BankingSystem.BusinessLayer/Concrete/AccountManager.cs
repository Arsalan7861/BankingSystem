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

        public void TcreateBankAccount(string customerTc, string accountType, decimal balance, string iban, string currency)
        {
            _accountDal.CreateBankAccount(customerTc, accountType, balance, iban, currency);
        }

        public void TDelete(int id)
        {
            var account = _accountDal.GetById(id);
            if (account != null)
            {
                _accountDal.Delete(account);
            }
        }

        public void TDeleteAccountByTcAndType(string customerTc, string accountType)
        {
            _accountDal.DeleteAccountByTcAndType(customerTc, accountType);
        }

        public void TdeleteBankAccount(int accountId)
        {
            _accountDal.DeleteBankAccount(accountId);
        }

        public List<Account> TGetAccountByTc(string customerTc)
        {
            return _accountDal.GetAccountByTc(customerTc);
        }

        public List<Account> TGetAll()
        {
            return _accountDal.GetAll();
        }

        public Account TGetById(int id)
        {
            return _accountDal.GetById(id);
        }

        public void TsendMoney(string senderTc, string receiverTc, decimal amount)
        {
            _accountDal.SendMoney(senderTc, receiverTc, amount);
        }

        public void TUpdate(Account entity)
        {
            _accountDal.Update(entity);
        }
    }
}




