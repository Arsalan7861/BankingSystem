using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Abstract
{
    public interface IAccountDal : IGenericDal<Account>
    {
        void SendMoney(string senderTc, string receiverTc, decimal amount);
        void CreateBankAccount(string customerTc, string accountType, decimal balance, string iban, string currency);
        void DeleteBankAccount(int accountId);
        List<Account> GetAccountByTc(string customerTc);
        void DeleteAccountByTcAndType(string customerTc, string accountType);
    }
}
