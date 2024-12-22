using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLayer.Abstract
{
    public interface IAccountService : IGenericService<Account>
    {
        void TdepositMoney(string customerTc, decimal amount);
        void TwithdrawMoney(string customerTc, decimal amount);
        void TsendMoney(string senderTc, string receiverTc, decimal amount);
        void TcreateBankAccount(string customerTc, string accountType, decimal balance, string iban, string currency);
        void TdeleteBankAccount(int accountId);
        List<Account> TGetAccountByTc(string customerTc);
        void TDeleteAccountByTcAndType(string customerTc, string accountType);
    }
}
